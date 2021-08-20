using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IGenericRepositoryWrapper<TblUser> _userRepository;
        private readonly IConfigSettings _settings;
        private readonly IGenericRepositoryWrapper<RefreshToken> _refreshTokenRepository;
        public AuthController(IGenericRepositoryWrapper<TblUser> userRepository,
            IGenericRepositoryWrapper<RefreshToken> refreshTokenRepository,
            IConfigSettings settings)
        {
            _userRepository = userRepository;
            _settings = settings;
            _refreshTokenRepository = refreshTokenRepository;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Secrets>> LogIn([FromBody] LogInModel logIn)
        {
            try
            {
                if (logIn == null)
                    BadRequest("Invalid process");

                if (!string.IsNullOrWhiteSpace(logIn.Token))
                {
                    var resultUser = await RefreshToken(logIn);
                    if (string.IsNullOrWhiteSpace(resultUser.Value.Username.ToString())
                        && (!string.IsNullOrWhiteSpace(logIn.Username) && !string.IsNullOrWhiteSpace(logIn.Password)))
                    {
                        var result = await _userRepository.Item.GetBy(x => x.Username == logIn.Username && x.Password == logIn.Password);
                        if (result.Count() != 0)
                        {
                            var token = await GenerateAccessToken(result.First().Id);
                            Secrets user = new Secrets();
                            user.Username = result.First().Username;
                            user.BucketName = _settings.BucketName;
                            user.AwsSecretKey = _settings.SecretKey;
                            user.AwsAccessKey = _settings.AccessKey;
                            user.Token = token;
                            user.Success = true;
                            return Ok(user);
                        }
                        else return NotFound("Utilisateur invalid");
                    }
                    else
                    {
                        return Ok(resultUser);
                    }
                }
                else
                {
                    if ((!string.IsNullOrWhiteSpace(logIn.Username) && !string.IsNullOrWhiteSpace(logIn.Password)))
                    {
                        var result = await _userRepository.Item.GetBy(x => x.Username == logIn.Username && x.Password == logIn.Password);
                        if (result.Count() != 0)
                        {
                            var token = await GenerateAccessToken(result.First().Id);
                            Secrets user = new Secrets();
                            user.Username = result.First().Username;
                            user.BucketName = _settings.BucketName;
                            user.AwsSecretKey = _settings.SecretKey;
                            user.AwsAccessKey = _settings.AccessKey;
                            user.Token = token;

                            return Ok(user);
                        }
                        else return NotFound("Utilisateur invalid");
                    }
                    else return BadRequest("Invalid Process");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("RefreshToken")]
        public async Task<ActionResult<Secrets>> RefreshToken([FromBody] LogInModel refreshRequest)
        {
            var user = await GetUserFromAccessToken(refreshRequest.Token);

            if (user != null && await ValidateRefreshToken(refreshRequest.Token))
            {
                Secrets userWithToken = new Secrets();
                userWithToken.Username = user.Username;
                userWithToken.Token = await GenerateAccessToken(user.Id);
                userWithToken.AwsAccessKey = _settings.AccessKey;
                userWithToken.AwsSecretKey = _settings.SecretKey;
                userWithToken.BucketName = _settings.BucketName;
                userWithToken.Success = true;
                return userWithToken;
            }
            return null;
        }

        // GET: api/Users
        [HttpPost("GetUserByAccessToken")]
        public async Task<ActionResult<LogInModel>> GetUserByAccessToken([FromBody] string accessToken)
        {
            LogInModel user = await GetUserFromAccessToken(accessToken);

            if (user != null)
            {
                return user;
            }
            return null;
        }

        private async Task<bool> ValidateRefreshToken(string refreshToken)
        {
            RefreshToken user = new RefreshToken();
            var refresh = await _refreshTokenRepository.Item.GetBy(x => x.Token == refreshToken
            && (x.Refreshable == "Oui" || x.Refreshable == null));
            if (refresh.Count() != 0)
            {
                user = refresh.First();
                if (user != null && user.DateOfExpiry < DateTime.UtcNow)
                {
                    return true;
                }
            }
            return false;
        }

        private async Task<LogInModel> GetUserFromAccessToken(string accessToken)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_settings.Key);

                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                SecurityToken securityToken;
                var principle = tokenHandler.ValidateToken(accessToken, tokenValidationParameters, out securityToken);

                JwtSecurityToken jwtSecurityToken = securityToken as JwtSecurityToken;

                if (jwtSecurityToken != null && jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    var userId = principle.FindFirst(ClaimTypes.Name)?.Value;

                    var user = await _refreshTokenRepository.Item.GetBy(x => x.Token == accessToken);

                    LogInModel model = new LogInModel();
                    model.Token = accessToken;
                    model.Id = (int)(user.First().UserId);
                    return model;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (ex.Message.Contains("expir"))
                    {
                        var user = await _refreshTokenRepository.Item.GetBy(x => x.Token == accessToken);
                        LogInModel model = new LogInModel();
                        model.Token = accessToken;
                        model.Id = (int)(user.First().UserId);
                        return model;
                    }
                    else return new LogInModel();
                }
                catch (Exception)
                {
                    return new LogInModel();
                }
            }
            return new LogInModel();
        }

        private async Task<string> GenerateAccessToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_settings.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserId", Convert.ToString(userId)),
                }),
                Audience = _settings.HostName,
                Expires = DateTime.UtcNow.AddHours(_settings.TokenDurationHours),
                IssuedAt = DateTime.Now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var result = tokenHandler.WriteToken(token);
            await _refreshTokenRepository.Item.AddAsync(new RefreshToken()
            {
                Refreshable = "Oui",
                Token = result,
                UserId = userId,
                DateOfExpiry = Convert.ToDateTime(tokenDescriptor.Expires),
                DateOfIssue = Convert.ToDateTime(tokenDescriptor.IssuedAt),
                RefreshTokenId = Guid.NewGuid(),
            });

            await _refreshTokenRepository.SaveAsync();
            return result;
        }
    }
}


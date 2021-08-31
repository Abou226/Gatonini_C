using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        const string Callback = "gatonini";
        private readonly IGenericRepositoryWrapper<User> _userRepository;
        private readonly IGenericRepositoryWrapper<ExternalLogin> _externalLoginRepository;
        private readonly IConfigSettings _settings;
        private readonly IFacebook _facebook;
        private readonly IGenericRepositoryWrapper<RefreshToken> _refreshTokenRepository;
        public AuthController(IGenericRepositoryWrapper<User> userRepository,
            IGenericRepositoryWrapper<RefreshToken> refreshTokenRepository,
            IGenericRepositoryWrapper<ExternalLogin> externalLoginRepository,
            IFacebook facebook,
            IConfigSettings settings)
        {
            _userRepository = userRepository;
            _settings = settings;
            _facebook = facebook;
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
                        var result = await _userRepository.Item.GetBy(x => x.Username == logIn.Username && x.Password == _settings.PaswordEncryption(logIn.Password + _settings.Key));
                        if (result.Count() != 0)
                        {
                            var token = await GenerateAccessToken(result.First().Id);
                            Secrets user = new Secrets();
                            user.Username = result.First().Username;
                            user.BucketName = _settings.BucketName;
                            user.AwsSecretKey = _settings.SecretKey;
                            user.AwsAccessKey = _settings.AccessKey;
                            user.Token = token.Token;
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
                        var result = await _userRepository.Item.GetBy(x => x.Username == logIn.Username && x.Password == _settings.PaswordEncryption(logIn.Password + _settings.Key));
                        if (result.Count() != 0)
                        {
                            var token = await GenerateAccessToken(result.First().Id);
                            Secrets user = new Secrets();
                            user.Username = result.First().Username;
                            user.BucketName = _settings.BucketName;
                            user.AwsSecretKey = _settings.SecretKey;
                            user.AwsAccessKey = _settings.AccessKey;
                            user.Token = token.Token;

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
                var result = await GenerateAccessToken(user.Id);
                Secrets userWithToken = new Secrets();
                userWithToken.Username = user.Username;
                userWithToken.Token = result.Token;
                userWithToken.AwsAccessKey = _settings.AccessKey;
                userWithToken.AwsSecretKey = _settings.SecretKey;
                userWithToken.BucketName = _settings.BucketName;
                userWithToken.Success = true;
                return userWithToken;
            }
            return null;
        }


        [HttpGet("ExternalLogin/{scheme}")]
        public async Task ExternalLogIn([FromRoute] string scheme)
        {
            //NOTE: see https://docs.microsoft.com/en-us/xamarin/essentials/web-authenticator?tabs=android
            var auth = await Request.HttpContext.AuthenticateAsync(scheme);

            if (!auth.Succeeded
                || auth?.Principal == null
                || !auth.Principal.Identities.Any(id => id.IsAuthenticated)
                || string.IsNullOrEmpty(auth.Properties.GetTokenValue("access_token")))
            {
                // Not authenticated, challenge
                await Request.HttpContext.ChallengeAsync(scheme);
                //return null;
            }
            else
            {
                var claims = auth.Principal.Identities.FirstOrDefault()?.Claims;

                var email = string.Empty;
                email = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
                var givenName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.GivenName)?.Value;
                var surName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Surname)?.Value;
                var nameIdentifier = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                string picture = string.Empty;

                if (scheme == "Facebook")
                {
                    picture = await _facebook.GetFacebookProfilePicURL(auth.Properties.GetTokenValue("access_token"));
                }
                else if (scheme == "Google")
                    picture = claims?.FirstOrDefault(c => c.Type == "picture")?.Value;

                var item = await _userRepository.Item.GetBy(x => x.Email == email);
                User user = null;
                if (item.Count() != 0)
                {
                    user = item.First();
                }
                user = await _userRepository.Item.AddAsync(new Entities.Models.User()
                {
                    Email = email,
                    Prenom = givenName,
                    Nom = surName,
                    Url = picture,
                    Id = Guid.NewGuid(),
                    DateOfCreation = DateTime.Now,
                });

                await _externalLoginRepository.Item.AddAsync(new ExternalLogin()
                {
                    UserId = user.Id,
                    DateOfLogin = DateTime.Now,
                    Provider = scheme,
                    Id = Guid.NewGuid()
                });

                await _userRepository.SaveAsync();
                var authToken = await GenerateAccessToken(user.Id);
                //return new UserProfile()
                //{
                //    Email = user.Email,
                //    Prenom = user.Prenom,
                //    Nom = user.Nom,
                //    Url = user.Url,
                //    UserId = user.UserId,
                //    AwsAccessKey = _settings.AccessKey,
                //    AwsSecretKey = _settings.SecretKey,
                //    BucketName = _settings.BucketName,
                //    Token = authToken
                //};
                //Get parameters to send back to the callback

                var qs = new Dictionary<string, string>
                {
                    { "access_token", authToken.Token },
                    {"dateofexpiry", authToken.DateOfExpiry.ToString() },
                    { "refresh_token",  string.Empty },
                    { "email", email },
                    { "firstName", givenName },
                    { "picture", picture },
                    { "secondName", surName },
                };

                //Build the result url
                var url = Callback + "://#" + string.Join(
                    "&",
                    qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                    .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

                //Redirect to final url
                Request.HttpContext.Response.Redirect(url);
            }
        }

        [Authorize]
        [HttpGet("signout")]
        public async Task Signout()
        {
            await Request.HttpContext.SignOutAsync();
            //await _signInManager.SignOutAsync();
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

        [Authorize]
        [HttpGet("ExternalUserByAccessToken/")]
        public async Task<ActionResult<UserProfile>> GetExternalUserByAccessToken([FromBody] string accessToken)
        {
            LogInModel user = await GetUserFromAccessToken(accessToken);

            if (user != null)
            {
                var u = await _userRepository.Item.GetBy(x => x.Id == user.Id);
                if (u.Count() != 0)
                {
                    return new UserProfile()
                    {
                        UserId = u.First().Id,
                        AwsAccessKey = _settings.AccessKey,
                        AwsSecretKey = _settings.SecretKey,
                        BucketName = _settings.BucketName,
                        Url = u.First().Url,
                        Email = u.First().Email,
                        Nom = u.First().Nom,
                        Prenom = u.First().Prenom,
                        Token = user.Token,
                    };
                }
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
                    model.Id = (Guid)(user.First().UserId);
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
                        model.Id = (Guid)(user.First().UserId);
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

        [HttpGet("UserEmail/{email}")]
        private async Task<Secrets> GetUserFromEmail(string email)
        {
            try
            {
                var user = await _userRepository.Item.GetBy(x => x.Email == email);
                if (user.Count() != 0)
                {
                    var token = await GenerateAccessToken(user.First().Id);
                    return new Secrets()
                    {
                        Token = token.Token,
                        AwsAccessKey = _settings.AccessKey,
                        AwsSecretKey = _settings.SecretKey,
                        BucketName = _settings.BucketName
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private async Task<TokenDetails> GenerateAccessToken(Guid userId)
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
                Id = Guid.NewGuid(),
            });

            await _refreshTokenRepository.SaveAsync();
            return new TokenDetails()
            {
                DateOfExpiry = Convert.ToDateTime(tokenDescriptor.Expires),
                IssueAt = Convert.ToDateTime(tokenDescriptor.IssuedAt),
                Token = result,
            };
        }
    }
}

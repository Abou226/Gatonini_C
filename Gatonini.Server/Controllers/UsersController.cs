using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gatonini.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : GenericController<User>
    {
        private readonly IGenericRepositoryWrapper<User> repositoryWrapper;
        private readonly IConfigSettings _settings;
        private readonly IGenericRepositoryWrapper<RefreshToken> _refreshToken;
        private readonly IMapper _mapper;
        public UsersController(IGenericRepositoryWrapper<User> wrapper,
            IConfigSettings settings,
            IGenericRepositoryWrapper<RefreshToken> refreshToken, IMapper mapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
            _settings = settings;
            _refreshToken = refreshToken;
            _mapper = mapper;
        }

        [HttpPatch("id")]
        public async Task<ActionResult<User>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            try
            {
                var item = await repositoryWrapper.Item.GetBy(x => x.Id == id);
                if (item.Count() != 0)
                {
                    var single = item.First();
                    value.ApplyTo(single);
                    await repositoryWrapper.SaveAsync();
                }
                else return NotFound("User not indentified");

                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpDelete("{id:Guid}")]
        public  async Task<ActionResult<User>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var values = await _refreshToken.Item.GetBy(x => x.UserId == id);
                    if (values.Count() != 0)
                    {
                        foreach (var item in values)
                        {
                            _refreshToken.Item.Delete(item);
                            await _refreshToken.SaveAsync();
                        }
                    }
                    User u = new User();
                    u.Id = id;
                    repositoryWrapper.Item.Delete(u);
                    await repositoryWrapper.SaveAsync();
                    return Ok(u);
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetAll();

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        public override async Task<ActionResult<IEnumerable<User>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Prenom.ToString().Equals(search)
                    || x.Nom.Contains(search) || x.Prenom.Contains(search) || x.Email.Contains(search));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [AllowAnonymous]
        public override async Task<ActionResult<User>> AddAsync([FromBody] User value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                //var identity = await repositoryWrapper.ItemA.GetBy(x => x.UserId.ToString().
                //Equals(((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value));

                //if (identity.Count() != 0)
                var u = await repositoryWrapper.Item.GetBy(x => x.Username == value.Username);
                if (u.Count() != 0)
                    return BadRequest("Nom d'utilisateur deja existant, veiller choisir un nom d'utilisateur unique");
                {
                    
                    value.Id = Guid.NewGuid();

                    if (value.DateOfCreation == Convert.ToDateTime("0001-01-01T00:00:00"))
                        value.DateOfCreation = DateTime.Now;
                    value.ServerTime = DateTime.Now;
                    if (!string.IsNullOrWhiteSpace(value.Password))
                        value.Password = _settings.PaswordEncryption(value.Password + _settings.Key);
                    await repositoryWrapper.Item.AddAsync(value);
                    await repositoryWrapper.SaveAsync();
                }
                //else return NotFound();

                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        public override async Task<ActionResult<IEnumerable<User>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Nom.Contains(search)
                    || x.Prenom.Contains(search) || x.Email.Contains(search) && (x.DateOfCreation >= start && x.DateOfCreation <= end));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

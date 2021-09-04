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
    public class ContinentsController : GenericController<Continent>
    {
        private readonly IGenericRepositoryWrapper<Continent> repositoryWrapper;
        private readonly IConfigSettings _settings;
        private readonly IMapper _mapper;
        public ContinentsController(IGenericRepositoryWrapper<Continent> wrapper,
            IConfigSettings settings, IMapper mapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
            _settings = settings;
            _mapper = mapper;
        }

        [HttpPatch("id")]
        public async Task<ActionResult<Continent>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }


        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Continent>> Delete([FromRoute] Guid id)
        {
            try
            {
                Continent u = new Continent();
                u.Id = id;
                repositoryWrapper.Item.Delete(u);
                await repositoryWrapper.SaveAsync();
                return Ok(u);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<Continent>>> GetAll()
        {
            try
            {
                var result = await repositoryWrapper.Item.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }


        public override async Task<ActionResult<IEnumerable<Continent>>> GetBy(string search)
        {
            try
            {
                var result = await repositoryWrapper.Item.GetBy(x => x.Name.ToString().Equals(search));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<Continent>> AddAsync([FromBody] Continent value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                var item = await repositoryWrapper.Item.GetBy(x => x.Name == value.Name);
                if(item.Count() == 0)
                {
                    value.Id = Guid.NewGuid();
                    await repositoryWrapper.Item.AddAsync(value);
                    await repositoryWrapper.SaveAsync();
                }
                else  Ok("Element déjà existant");
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }
    }
}

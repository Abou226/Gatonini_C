using Amazon.S3;
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
    public class ProduitsController : GenericController<Produit, User, Gamme, Marque, Style, Taille, Model, Categorie>
    {
        private readonly IAmazonS3 _amazonS3;
        private readonly IGenericRepositoryWrapper<Produit, User, Gamme, Marque, Style, Taille, Model, Categorie> repositoryWrapper;
        private readonly IConfigSettings _settings;
        private readonly IMapper _mapper;
        public ProduitsController(IGenericRepositoryWrapper<Produit, User, Gamme, 
            Marque, Style, Taille, Model, Categorie> wrapper,
            IConfigSettings settings, IMapper mapper, IAmazonS3 amazon) : base(wrapper)
        {
            repositoryWrapper = wrapper;
            _settings = settings;
            _mapper = mapper;
            _amazonS3 = amazon;
        }

        [HttpPatch("id")]
        public async Task<ActionResult<Produit>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
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
        public async Task<ActionResult<Produit>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    Produit u = new Produit();
                    u.Id = id;
                    repositoryWrapper.Item.Delete(u);
                    await repositoryWrapper.SaveAsync();
                    return Ok(u);
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<Produit>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }


        public override async Task<ActionResult<IEnumerable<Produit>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.ModelId.ToString().Equals(search) 
                    || x.GammeId.ToString().Contains(search), 
                        x => x.Gamme, x => x.Gamme.Marque, x =>x.Gamme.Style, x => x.Taille, x => x.Model, x => x.Gamme.Categorie);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<Produit>> AddAsync([FromBody] Produit value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                value.Id = Guid.NewGuid();
                await repositoryWrapper.Item.AddAsync(value);
                await repositoryWrapper.SaveAsync();

                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }
    }
}

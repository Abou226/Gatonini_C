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
    public class GateauFinisController : GenericController<GateauFini, User, Stock_Produit, Gamme,
        Marque, Style, Taille, Model, Categorie, Produit>
    {
        private readonly IGenericRepositoryWrapper<GateauFini, User, Stock_Produit, Gamme, 
            Marque, Style, Taille, Model, Categorie, Produit> repositoryWrapper;
        private readonly IConfigSettings _settings;
        private readonly IMapper _mapper;
        public GateauFinisController(IGenericRepositoryWrapper<GateauFini, User, Stock_Produit, Gamme,
            Marque, Style, Taille, Model, Categorie, Produit> wrapper,
            IConfigSettings settings, IMapper mapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
            _settings = settings;
            _mapper = mapper;
        }

        [HttpPatch("id")]
        public async Task<ActionResult<GateauFini>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
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
        public async Task<ActionResult<GateauFini>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    GateauFini u = new GateauFini();
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

        public override async Task<ActionResult<IEnumerable<GateauFini>>> GetAll()
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<GateauFini>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Id.ToString().Equals(search)
                    || x.Stock.Produit.GammeId.ToString().Contains(search),
                        x => x.Stock,x => x.Stock.Produit.Gamme, x => x.Stock.Produit.Gamme.Marque, 
                        x => x.Stock.Produit.Gamme.Style, x => x.Stock.Produit.Taille, 
                        x => x.Stock.Produit.Model, x => x.Stock.Produit.Gamme.Categorie, 
                        x => x.Stock.Produit);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<GateauFini>> AddAsync([FromBody] GateauFini value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                {
                    value.Id = Guid.NewGuid();
                    await repositoryWrapper.Item.AddAsync(value);
                    await repositoryWrapper.SaveAsync();
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }
    }
}

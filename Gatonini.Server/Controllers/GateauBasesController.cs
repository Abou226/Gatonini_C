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
    public class GateauBasesController : GenericController<GateauBase, User, Stock_Base, Produit, Gamme,
        Marque, Style, Taille, Model, Categorie>
    {
        private readonly IGenericRepositoryWrapper<GateauBase, User, Stock_Base, Produit, Gamme,
            Marque, Style, Taille, Model, Categorie> repositoryWrapper;
        private readonly IConfigSettings _settings;
        private readonly IMapper _mapper;
        public GateauBasesController(IGenericRepositoryWrapper<GateauBase, User, Stock_Base, Produit, Gamme,
            Marque, Style, Taille, Model, Categorie> wrapper,
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
        public async Task<ActionResult<GateauBase>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    GateauBase u = new GateauBase();
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

        public override async Task<ActionResult<IEnumerable<GateauBase>>> GetAll()
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

        public override async Task<ActionResult<IEnumerable<GateauBase>>> GetBy(string search)
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
                        x => x.Stock, x => x.Stock.Produit, x => x.Stock.Produit.Gamme, x => x.Stock.Produit.Gamme.Marque,
                        x => x.Stock.Produit.Gamme.Style, x => x.Stock.Produit.Taille,
                        x => x.Stock.Produit.Model, x => x.Stock.Produit.Gamme.Categorie);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        public override async Task<ActionResult<GateauBase>> AddAsync([FromBody] GateauBase value)
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

        [HttpGet("{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GateauBase>>> GetByInclude(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Date.Date <= end
                    && x.Date.Date >= start, x => x.Stock, x=> x.Stock.Produit, x => x.Stock.Produit.Gamme, x => x.Stock.Produit.Gamme.Marque,
                    x => x.Stock.Produit.Gamme.Style, x => x.Stock.Produit.Taille, x => x.Stock.Produit.Model);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

    }
}

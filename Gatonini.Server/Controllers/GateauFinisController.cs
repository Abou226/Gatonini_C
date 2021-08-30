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
    public class GateauFinisController : GenericController<GateauFini, User, Gamme, Marque, Style, Categorie, Model, Taille, Stock_Produit>
    {
        private readonly IGenericRepositoryWrapper<GateauFini, User, Gamme, Marque, Style, Categorie, Model, Taille, Stock_Produit> repositoryWrapper;
        public GateauFinisController(IGenericRepositoryWrapper<GateauFini, User, Gamme, Marque, Style, Categorie, Model, Taille, Stock_Produit> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id}")]
        public override async Task<ActionResult<GateauFini>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
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
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<GateauFini>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme, x => x.Produit.Gamme.Marque,
                        x => x.Produit.Gamme.Style, x => x.Produit.Gamme.Categorie, x => x.Produit.Model, x => x.Produit.Taille);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
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
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme.Description.Contains(search)
                    || x.Produit.Gamme.Categorie.Name.Contains(search) || x.Produit.Gamme.Marque.Name.Contains(search)
                    || x.Produit.Gamme.Style.Name.Contains(search), x => x.Produit.Gamme,
                    x => x.Produit.Gamme.Marque, x => x.Produit.Gamme.Style,
                    x => x.Produit.Gamme.Categorie, x => x.Produit.Model,
                    x => x.Produit.Taille);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur de serveur");
            }
        }

        public override async Task<ActionResult<GateauFini>> AddAsync([FromBody] GateauFini value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    value.Id = Guid.NewGuid();
                    value.UserId = identity.First().Id;
                    if (value.Date == Convert.ToDateTime("0001-01-01T00:00:00"))
                        value.Date = DateTime.Now;

                    //value.ServerTime = DateTime.Now;
                    await repositoryWrapper.ItemA.AddAsync(value);
                    await repositoryWrapper.SaveAsync();
                    var prd = await repositoryWrapper.ItemI.GetBy(x => x.ProduitId == value.ProduitId);
                    if(prd.Count() != 0)
                    {
                        var sp = prd.First().Quantité += value.Quantité;
                        JsonPatchDocument edit = new JsonPatchDocument();
                        edit.Add("path", "Quantité");
                        edit.Add("op", "Replace");
                        edit.Add("value", sp);
                        edit.ApplyTo(prd);
                        await repositoryWrapper.SaveAsync();
                    }else
                    {
                        var res = await repositoryWrapper.ItemI.AddAsync(new Stock_Produit()
                        {
                            Id = Guid.NewGuid(),
                            ProduitId = value.ProduitId,
                            FilialeId = value.FilialeId,
                            Quantité = value.Quantité,
                        });
                        await repositoryWrapper.SaveAsync();
                    }
                }
                else return NotFound("User not indentified");

                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<GateauFini>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme.Description.Contains(search)
                    || x.Produit.Gamme.Categorie.Name.Contains(search) || x.Produit.Gamme.Marque.Name.Contains(search) || x.Produit.Gamme.Style.Name.Contains(search) &&
                    (x.Date >= start && x.Date <= end), x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Gamme.Style, x => x.Produit.Gamme.Categorie, x => x.Produit.Model, x => x.Produit.Taille);

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

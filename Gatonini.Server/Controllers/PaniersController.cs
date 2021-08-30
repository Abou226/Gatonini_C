using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gatonini.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaniersController : GenericController<Panier, User, Gamme, Marque, Taille, Model, Style, Categorie, Client, Quartier>
    {
        private readonly IGenericRepositoryWrapper<Panier, User, Gamme, Marque, Taille, Model, Style, Categorie, Client, Quartier> repositoryWrapper;
        public PaniersController(IGenericRepositoryWrapper<Panier, User, Gamme, Marque, Taille, Model, Style, Categorie, Client, Quartier> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id}")]
        public override async Task<ActionResult<Panier>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    Panier u = new Panier();
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

        public override async Task<ActionResult<IEnumerable<Panier>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Produit.Gamme.Categorie, x => x.Client, x => x.Quartier);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<Panier>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme.Marque.Name.Contains(search)
                    || x.Produit.Gamme.Categorie.Name.Contains(search) || x.Produit.Gamme.Style.Name.Contains(search) 
                    || x.Client.Prenom.Contains(search) || x.Client.Nom.Contains(search) 
                    || x.Client.Genre.Equals(search), x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, 
                    x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Produit.Gamme.Categorie, x => x.Client, x => x.Quartier);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<Panier>> AddAsync([FromBody] Panier value)
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
                    if (value.DateOfCreation == Convert.ToDateTime("0001-01-01T00:00:00"))
                        value.DateOfCreation = DateTime.Now;
                    value.ServerTime = DateTime.Now;
                    await repositoryWrapper.ItemA.AddAsync(value);
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

        public override async Task<ActionResult<IEnumerable<Panier>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit.Gamme.Marque.Name.Contains(search)
                    || x.Produit.Gamme.Categorie.Name.Contains(search) || x.Produit.Gamme.Style.Name.Contains(search)
                    || x.Client.Prenom.Contains(search) || x.Client.Nom.Contains(search)
                    || x.Client.Genre.Equals(search) && (x.DateOfCreation.Date >= start && x.DateOfCreation.Date <= end), 
                    x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, 
                    x => x.Produit.Gamme.Categorie, x => x.Client, x => x.Quartier);
                    
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

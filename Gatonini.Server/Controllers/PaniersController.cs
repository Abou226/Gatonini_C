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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaniersController : GenericController<Panier, User, Produit, Gamme, 
        Marque, Taille, Model, Style, Quartier, Client>
    {
        private readonly IGenericRepositoryWrapper<Panier, User, Produit, Gamme, 
            Marque, Taille, Model, Style, Quartier, Client> repositoryWrapper;
        public PaniersController(IGenericRepositoryWrapper<Panier, User, Produit, Gamme, 
            Marque, Taille, Model, Style, Quartier, Client> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Panier>> DeleteAsync([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var c = await repositoryWrapper.Item.GetBy(x => x.Id == id);
                    if (c.Count() != 0)
                    {
                        repositoryWrapper.Item.Delete(c.First());
                        await repositoryWrapper.SaveAsync();
                        return Ok(c.First());
                    }
                    else return NotFound("Element non trouvé");
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpPatch("id")]
        public async Task<ActionResult<Panier>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
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

        public override async Task<ActionResult<IEnumerable<Panier>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Produit.Gamme, 
                        x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, 
                        x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpGet("All/{start:DateTime}/{end:DateTime}")]
        public async Task<ActionResult<IEnumerable<Panier>>> GetAll(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Produit.Gamme, 
                        x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, 
                        x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client, 
                        x => x.DateOfCreation.Date <= end && x.DateOfCreation.Date >= start);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpGet("{userid:Guid}")]
        public async Task<ActionResult<IEnumerable<Panier>>> GetAllForUser(Guid userid)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Produit.Gamme, 
                        x => x.Produit.Gamme.Marque, x => x.Produit.Taille, 
                        x => x.Produit.Model, x => x.Produit.Gamme.Style, 
                        x => x.Quartier, x => x.Client, x => x.UserId == userid);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpGet("All/{search}")]
        public async Task<ActionResult<IEnumerable<Panier>>> GetAll(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Produit.Gamme, x => x.Produit.Gamme.Marque,
                        x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client, x => x.Client.Contact.Equals(search)
                    || x.Client.ToString().Contains(search) || x.Details_Adresse.Contains(search) || x.Quartier.Name.Contains(search)
                    || x.Heure_Livraison.Contains(search));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
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
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit,
                        x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille,
                        x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client, x => x.Client.Contact.Equals(search)
                    || x.Client.ToString().Contains(search) || x.Details_Adresse.Contains(search)
                    || x.Heure_Livraison.Contains(search) && (x.UserId == identity.First().Id));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpGet("{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Panier>>> GetByInclude(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.DateOfCreation.Date <= end
                    && x.DateOfCreation.Date >= start && (x.UserId == identity.First().Id), x => x.Produit, x => x.Produit.Gamme,
                    x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
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

                    
                    var prod = await repositoryWrapper.ItemC.GetBy(x => x.Id == value.ProduitId);
                    string url = "";
                    if (prod.Count() == 0)
                    {

                        if (value.Produit == null)
                        {
                            var produit = prod;
                            if (produit.Count() != 0)
                            {
                                value.Produit = produit.First();
                            }
                        }

                    }
                    else
                    {
                        //if (!string.IsNullOrWhiteSpace(value.Produit.Gamme.Url))
                        //    url = value.Produit.Gamme.Url;
                        //else
                        //{
                        //    var mar = await repositoryWrapper.ItemE.GetBy(x => x.MarqueId == value.Produit.Gamme.MarqueId);
                        //    if (mar.Count() != 0)
                        //    {
                        //        value.Produit.Gamme.Marque = mar.First();
                        //    }
                        //    url = value.Produit.Gamme.Marque.Url;
                        //}

                        //await repositoryWrapper.ItemI.AddAsync(new Produit()
                        //{
                        //    Id = Guid.NewGuid(),
                        //    GammeId = value.Produit.GammeId,
                        //    ModelId = value.Produit.ModelId,
                        //    TailleId = value.Produit.TailleId,
                        //    Prix_Unité = value.Gamme.Prix_Unité * Convert.ToDecimal(value.Taille.Name),
                        //    DateOfCreation = DateTime.Now,
                        //    ServerTime = DateTime.Now,
                        //    Stock = 0,
                        //    Url = url,
                        //    UserId = identity.First().UserId,
                        //});
                        //await repositoryWrapper.SaveAsync();
                    }

                    value.ServerTime = DateTime.Now;

                    value.Produit = null;
                    value.Quartier = null;
                    await repositoryWrapper.ItemA.AddAsync(value);
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

        public override async Task<ActionResult<IEnumerable<Panier>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Produit.Gamme,
                        x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model,
                        x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client,
                    x => x.Client.Contact.Equals(search)
                    || x.Client.ToString().Contains(search)
                    || x.Client.Contact.Contains(search)
                    || x.Quartier.Name.Contains(search)
                    || x.Heure_Livraison.Contains(search) &&
                    (x.DateOfCreation.Date <= end
                    && x.DateOfCreation.Date >= start)
                    && (x.UserId == identity.First().Id));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException.Message);
            }
        }

        [HttpGet("All/{search}/{start:DateTime}/{end:DateTime}")]
        public async Task<ActionResult<IEnumerable<Panier>>> GetAll(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit,
                        x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille,
                        x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client,
                        x => x.Client.Contact.Equals(search)
                    || x.Client.Prenom.ToString().Contains(search) || x.Client.Nom.Contains(search)
                    || x.Client.Contact.Contains(search)
                    || x.Quartier.Name.Contains(search)
                    || x.Heure_Livraison.Contains(search) &&
                    (x.DateOfCreation.Date <= end
                    && x.DateOfCreation.Date >= start));

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

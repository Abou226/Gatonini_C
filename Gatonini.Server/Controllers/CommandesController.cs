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
    public class ReservationsController : GenericController<Commande, User, Produit, Num_Vente, Gamme, Marque, Taille, Model, Style, Quartier, Client, Stock_Produit>
    {
        private readonly IGenericRepositoryWrapper<Commande, User, Produit, Num_Vente, Gamme, Marque, Taille, Model, Style, Quartier, Client, Stock_Produit> repositoryWrapper;
        public ReservationsController(IGenericRepositoryWrapper<Commande, User, Produit, Num_Vente, Gamme, Marque, Taille, Model, Style, Quartier, Client, Stock_Produit> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Commande>> AnnuléeAsync([FromRoute] Guid id)
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
                        var prod = await repositoryWrapper.ItemL.GetBy(x => x.Id == c.First().ProduitId);
                        
                        if (prod.Count() != 0)
                        {
                            JsonPatchDocument value = new JsonPatchDocument();
                            value.Add("path", "Quantité");
                            value.Add("value", prod.First().Quantité + c.First().Quantité);
                            value.Add("op", "replace");
                            var single = prod.First();
                            value.ApplyTo(single);

                            JsonPatchDocument values = new JsonPatchDocument();
                            values.Add("path", "Annulée");
                            values.Add("value", true);
                            values.Add("op", "replace");
                            var singles = c.First();
                            values.ApplyTo(singles);
                            await repositoryWrapper.SaveAsync();
                        }
                        return Ok(c.First());
                    }
                    else return NotFound("Element non trouvé");
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Commande>> DeleteAsync([FromRoute] Guid id)
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
                        var prod = await repositoryWrapper.ItemL.GetBy(x => x.Id == c.First().ProduitId);

                        if (prod.Count() != 0)
                        {
                            repositoryWrapper.Item.Delete(c.First());
                            await repositoryWrapper.SaveAsync();
                        }
                        return Ok(c.First());
                    }
                    else return NotFound("Element non trouvé");
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch("id")]
        public async Task<ActionResult<Commande>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
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

        public override async Task<ActionResult<IEnumerable<Commande>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("All/{start:DateTime}/{end:DateTime}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAll(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.DateOfCreation.Date <= end && x.DateOfCreation.Date >= start);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{userid:Guid}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAllForUser(Guid userid)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.UserId == userid);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("All/{search}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAll(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, 
                        x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Num_Vente.Numero.Equals(search)
                    || x.Client.ToString().Contains(search) || x.Details_Adresse.Contains(search) || x.Quartier.Name.Contains(search)
                    || x.Heure_Livraison.Contains(search));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<Commande>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, 
                        x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, 
                        x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client, x => x.Num_Vente.Numero.Equals(search)
                    || x.Client.ToString().Contains(search) || x.Details_Adresse.Contains(search)
                    || x.Heure_Livraison.Contains(search) && (x.UserId == identity.First().Id));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetByInclude(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.DateOfCreation.Date <= end
                    && x.DateOfCreation.Date >= start && (x.UserId == identity.First().Id), x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, 
                    x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<Commande>> AddAsync([FromBody] Commande value)
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

                    var taille = await repositoryWrapper.ItemG.GetBy(x => x.Name == value.Produit.Taille.Name);
                    if (taille.Count() != 0)
                    {
                        value.Produit.Taille = taille.First();
                        value.Produit.TailleId = taille.First().TailleId;
                    }
                    else
                    {
                        value.Produit.Taille = new Taille()
                        {
                            Name = value.Produit.Taille.Name,
                            TailleId = Guid.NewGuid(),
                            DateOfCreation = DateTime.Now,
                            ServerTime = DateTime.Now,
                            UserId = identity.First().Id
                        };
                        value.Produit.TailleId = value.Produit.Taille.TailleId;
                        await repositoryWrapper.ItemG.AddAsync(value.Produit.Taille);
                        await repositoryWrapper.SaveAsync();
                    }

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
                        
                    }else
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
                    value.Num_Vente = null;
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

        public override async Task<ActionResult<IEnumerable<Commande>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, x => x.Produit.Gamme, 
                        x => x.Produit.Gamme.Marque, x => x.Produit.Taille, x => x.Produit.Model, 
                        x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client,
                    x => x.Num_Vente.Numero.Equals(search)
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("All/{search}/{start:DateTime}/{end:DateTime}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAll(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Produit, x => x.Num_Vente, 
                        x => x.Produit.Gamme, x => x.Produit.Gamme.Marque, x => x.Produit.Taille, 
                        x => x.Produit.Model, x => x.Produit.Gamme.Style, x => x.Quartier, x => x.Client,
                        x => x.Num_Vente.Numero.Equals(search)
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

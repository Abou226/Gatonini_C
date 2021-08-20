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
    public class PlaningGateausController : GenericController<TblPlaningGateau, TblUser, Gamme, Marque, Taille, Model, Style>
    {
        private readonly IGenericRepositoryWrapper<TblPlaningGateau, TblUser, Gamme, Marque, Taille, Model, Style> repositoryWrapper;
        public PlaningGateausController(IGenericRepositoryWrapper<TblPlaningGateau, TblUser, Gamme, Marque, Taille, Model, Style> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id:int}")]
        public override async Task<ActionResult<TblPlaningGateau>> Delete([FromRoute] int id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    TblPlaningGateau u = new TblPlaningGateau();
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

        public override async Task<ActionResult<IEnumerable<TblPlaningGateau>>> GetAll()
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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch("{id:int}")]
        public override async Task<ActionResult<TblPlaningGateau>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromRoute] int id)
        {
            try
            {
                var item = await repositoryWrapper.Item.GetBy(x => x.Id == id);
                if (item.Count() != 0)
                {
                    var single = item.FirstOrDefault();
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

        public override async Task<ActionResult<IEnumerable<TblPlaningGateau>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Id.ToString().Equals(search)
                    || x.Gateau.ToString().Equals(search) || x.Assignation.ToString().Equals(search)
                    || x.Forme.Contains(search) || x.NbPart.ToString().Contains(search));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Authorize]
        public override async Task<ActionResult<TblPlaningGateau>> AddAsync([FromBody] TblPlaningGateau value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().Equals(claim));
                if (identity.Count() != 0)
                {
                    var reser = await repositoryWrapper.Item.GetLast(x => x.Id != 0);

                    value.Id = reser.Id + 1;
                    if (value.DateRequette == Convert.ToDateTime("0001-01-01T00:00:00"))
                        value.DateRequette = DateTime.Now;


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

        public override async Task<ActionResult<IEnumerable<TblPlaningGateau>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(
                        x => x.GammeId.ToString().Contains(search)
                    || x.Gamme.MarqueId.ToString().Equals(search)
                    || x.Gamme.Marque.Name.Equals(search)
                    || x.Gamme.Categorie.Name.Contains(search)
                    || x.Gamme.Style.Id.ToString().Equals(search) &&
                    (x.DateRequette >= start && x.DateRequette <= end), x => x.Gamme, x => x.Gamme.Marque, x => x.Taille, x => x.Model, x => x.Gamme.Style);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{categorie}/{marque}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Gamme>>> GetByTermes(string categorie, string marque, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(
                        x => x.Gamme.MarqueId.ToString().Equals(marque)
                    || x.Gamme.Marque.Name.Equals(marque)
                    || x.Gamme.Categorie.Name.Contains(categorie)
                    || x.Gamme.CategorieId.ToString().Equals(categorie) &&
                    (x.DateRequette >= start && x.DateRequette <= end), x => x.Gamme, x => x.Gamme.Marque, x => x.Taille, x => x.Model, x => x.Gamme.Style);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //[HttpGet("{categorie}/{marque}")]
        //[Authorize]
        //public async Task<ActionResult<IEnumerable<Gamme>>> GetByTermes(string categorie, string marque)
        //{
        //    try
        //    {
        //        var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
        //        var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
        //        Equals(claim));

        //        if (identity.Count() != 0)
        //        {
        //            var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style, x => x.Categorie,
        //                x => (x.CategorieId.ToString().Contains(categorie) && x.MarqueId.ToString().Equals(marque))
        //            || (x.Marque.Name.Contains(marque) && x.Categorie.Name.Contains(categorie)));
        //            return Ok(result);
        //        }
        //        else return NotFound("User not indentified");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}
    }
}


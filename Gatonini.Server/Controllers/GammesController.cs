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
    public class GammesController : GenericController<Gamme, TblUser, Marque, Style, Categorie>
    {
        private readonly IGenericRepositoryWrapper<Gamme, TblUser, Marque, Style, Categorie> repositoryWrapper;
        public GammesController(IGenericRepositoryWrapper<Gamme, TblUser, Marque, Style, Categorie> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Gamme>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    Gamme u = new Gamme();
                    u.GammeId = id;
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

        public override async Task<ActionResult<IEnumerable<Gamme>>> GetAll()
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch("{id:Guid}")]
        public async Task<ActionResult<Gamme>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromRoute] Guid id)
        {
            try
            {
                var item = await repositoryWrapper.Item.GetBy(x => x.GammeId == id);
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

        public override async Task<ActionResult<IEnumerable<Gamme>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style, x => x.Categorie, x => x.GammeId.ToString().Equals(search)
                    || x.CategorieId.ToString().Equals(search) || x.MarqueId.ToString().Equals(search)
                    || x.Marque.Name.Contains(search) || x.Categorie.Name.Contains(search)
                    || x.Style.Name.Contains(search)
                    || x.StyleId.ToString().Equals(search));

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
        public override async Task<ActionResult<Gamme>> AddAsync([FromBody] Gamme value)
        {
            try
            {
                if (value == null)
                    return NotFound();

                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().Equals(claim));
                if (identity.Count() != 0)
                {
                    value.GammeId = Guid.NewGuid();
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

        public override async Task<ActionResult<IEnumerable<Gamme>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style, x => x.Categorie,
                        x => x.CategorieId.ToString().Contains(search)
                    || x.CategorieId.ToString().Equals(search) || x.MarqueId.ToString().Equals(search)
                    || x.Marque.Name.Contains(search) || x.Categorie.Name.Contains(search)
                    || x.StyleId.ToString().Equals(search) &&
                    (x.DateOfCreation >= start && x.DateOfCreation <= end));

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
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style, x => x.Categorie,
                        x =>
                       (x.CategorieId.ToString().Contains(categorie) && x.MarqueId.ToString().Equals(marque))
                    || (x.Marque.Name.Contains(marque) && x.Categorie.Name.Contains(categorie)) &&
                    (x.DateOfCreation >= start && x.DateOfCreation <= end));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{categorie}/{marque}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Gamme>>> GetByTermes(string categorie, string marque)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetByInclude(x => x.Marque, x => x.Style, x => x.Categorie,
                        x =>
                       (x.CategorieId.ToString().Contains(categorie) && x.MarqueId.ToString().Equals(marque))
                    || (x.Marque.Name.Contains(marque) && x.Categorie.Name.Contains(categorie)));

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

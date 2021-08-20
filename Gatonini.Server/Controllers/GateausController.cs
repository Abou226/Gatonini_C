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
    public class GateausController : GenericController<TblGrosGateau, TblUser>
    {
        private readonly IGenericRepositoryWrapper<TblGrosGateau, TblUser> repositoryWrapper;
        public GateausController(IGenericRepositoryWrapper<TblGrosGateau, TblUser> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id}")]
        public override async Task<ActionResult<TblGrosGateau>> Delete([FromRoute] int id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    TblGrosGateau u = new TblGrosGateau();
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

        public override async Task<ActionResult<TblGrosGateau>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] int id)
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

        public override async Task<ActionResult<IEnumerable<TblGrosGateau>>> GetAll()
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

        [HttpGet("{userid:Guid}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAllForUser(int userid)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Id == userid);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<TblGrosGateau>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Nom.Contains(search) || x.Categorie.Contains(search) || x.Auteur.Contains(search));

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
                    var result = await repositoryWrapper.Item.GetBy(x => x.DateAjout.Value.Date <= end
                    && x.DateAjout.Value.Date >= start);

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public override async Task<ActionResult<TblGrosGateau>> AddAsync([FromBody] TblGrosGateau value)
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
                    var reser = await repositoryWrapper.Item.GetLast(x => x.Id != 0);

                    value.Id = reser.Id + 1;
                    if (value.DateAjout == Convert.ToDateTime("0001-01-01T00:00:00"))
                        value.DateAjout = DateTime.Now;


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

        public override async Task<ActionResult<IEnumerable<TblGrosGateau>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(
                        x => x.Nom.ToString().Contains(search)
                    || x.Auteur.Contains(search)
                    || x.Categorie.Contains(search)
                    || x.Code.Contains(search) 
                    || x.Filename.Contains(search) 
                    || x.FilePath.Contains(search) &&
                    (x.DateAjout.Value.Date <= end
                    && x.DateAjout.Value.Date >= start));

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


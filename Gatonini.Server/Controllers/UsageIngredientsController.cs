﻿using Contracts;
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
    [Authorize]
    [ApiController]
    public class UsageIngredientsController : GenericController<UsageIngredient, User, Ingredient>
    {
        private readonly IGenericRepositoryWrapper<UsageIngredient, User, Ingredient> repositoryWrapper;
        public UsageIngredientsController(IGenericRepositoryWrapper<UsageIngredient, User, Ingredient> wrapper) : base(wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpDelete("{id}")]
        public override async Task<ActionResult<UsageIngredient>> Delete([FromRoute] Guid id)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    UsageIngredient u = new UsageIngredient();
                    u.Id = id;
                    repositoryWrapper.Item.Delete(u);
                    await repositoryWrapper.SaveAsync();
                    var prd = await repositoryWrapper.ItemC.GetBy(x => x.Id == u.IngredientId);
                    if (prd.Count() != 0)
                    {
                        var sp = prd.First().Quantité += u.Ingredient.Quantité;
                        JsonPatchDocument edit = new JsonPatchDocument();
                        edit.Add("path", "Quantité");
                        edit.Add("op", "Replace");
                        edit.Add("value", sp);
                        edit.ApplyTo(prd);
                        await repositoryWrapper.SaveAsync();
                    }
                    else
                    {
                        var res = await repositoryWrapper.ItemC.AddAsync(new Ingredient()
                        {
                            Id = Guid.NewGuid(),
                            Name = u.Ingredient.Name,
                            Quantité = u.Ingredient.Quantité,
                            Stock_Max = u.Ingredient.Stock_Max,
                            Stock_Min = u.Ingredient.Stock_Min,
                            Unité = u.Ingredient.Unité
                        }) ;
                        await repositoryWrapper.SaveAsync();
                    }
                    return Ok(u);
                }
                else return NotFound("Utilisateur non identifier");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        public override async Task<ActionResult<IEnumerable<UsageIngredient>>> GetAll()
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

        public override async Task<ActionResult<IEnumerable<UsageIngredient>>> GetBy(string search)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));
                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.ItemA.GetBy(x => x.Id.ToString().Equals(search));

                    return Ok(result);
                }
                else return NotFound("User not indentified");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur de serveur");
            }
        }

        public override async Task<ActionResult<UsageIngredient>> AddAsync([FromBody] UsageIngredient value)
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
                    //value.Id = Guid.NewGuid();
                    //value.UserId = identity.First().Id;
                    //if (value.DateOfCreation == Convert.ToDateTime("0001-01-01T00:00:00"))
                    //    value.DateOfCreation = DateTime.Now;

                    //value.ServerTime = DateTime.Now;
                    await repositoryWrapper.ItemA.AddAsync(value);
                    await repositoryWrapper.SaveAsync();

                    var prd = await repositoryWrapper.ItemC.GetBy(x => x.Id == value.IngredientId);
                    if (prd.Count() != 0)
                    {
                        var sp = prd.First().Quantité -= value.Ingredient.Quantité;
                        JsonPatchDocument edit = new JsonPatchDocument();
                        edit.Add("path", "Quantité");
                        edit.Add("op", "Replace");
                        edit.Add("value", sp);
                        edit.ApplyTo(prd);
                        await repositoryWrapper.SaveAsync();
                    }
                    else
                    {
                        var res = await repositoryWrapper.ItemC.AddAsync(new Ingredient()
                        {
                            Id = Guid.NewGuid(),
                            Name = value.Ingredient.Name,
                            Quantité = value.Ingredient.Quantité,
                            Stock_Max = value.Ingredient.Stock_Max,
                            Stock_Min = value.Ingredient.Stock_Min,
                            Unité = value.Ingredient.Unité
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

        public override async Task<ActionResult<IEnumerable<UsageIngredient>>> GetBy(string search, DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.ItemA.GetBy(x => x.Ingredient.Name.Contains(search) &&
                    (x.Date >= start && x.Date <= end));

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
        public async Task<ActionResult<IEnumerable<UsageIngredient>>> GetBy(DateTime start, DateTime end)
        {
            try
            {
                var claim = (((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "UserId").Value);
                var identity = await repositoryWrapper.ItemB.GetBy(x => x.Id.ToString().
                Equals(claim));

                if (identity.Count() != 0)
                {
                    var result = await repositoryWrapper.Item.GetBy(x => x.Date.Date >= start && x.Date.Date <= end);

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

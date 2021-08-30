using Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    [Authorize]
    public class GenericController<A> : ControllerBase,
        IGenericController<A> where A : class
    {
        private readonly IGenericRepositoryWrapper<A> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.Item.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B> : ControllerBase, 
        IGenericController<A, B> where A : class where B : class
    {
        private readonly IGenericRepositoryWrapper<A, B> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            return null;
        }

    }

    public class GenericController<A, B, C> : ControllerBase, 
        IGenericController<A, B, C> where A : class where B : class where C : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur enregistrement");
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D> : ControllerBase, 
        IGenericController<A, B, C, D> 
        where A : class where B : class where C : class where D : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("search")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("search/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, 
            DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E> : ControllerBase, 
        IGenericController<A, B, C, D, E> where A : class where B : class
        where C : class where D : class where E : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }



        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erreur enregistrement");
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F> : ControllerBase, 
        IGenericController<A, B, C, D, E, F> where A : class where B : class 
        where C : class where D : class where E : class where F : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F, G> : ControllerBase,
        IGenericController<A, B, C, D, E, F, G> where A : class where B : class
        where C : class where D : class where E : class where F : class where G : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F, G> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F, G> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value,  [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F, G, H> : ControllerBase,
       IGenericController<A, B, C, D, E, F, G, H> where A : class where B : class
       where C : class where D : class where E : class where F : class where G : class where H : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F, G, H> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F, G, H> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F, G, H, I> : ControllerBase,
       IGenericController<A, B, C, D, E, F, G, H, I> where A : class where B : class
       where C : class where D : class where E : class where F : class where G : class where H : class where I : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F, G, H, I, K> : ControllerBase,
       IGenericController<A, B, C, D, E, F, G, H, I, K> where A : class where B : class
       where C : class where D : class where E : class where F : class where G : class where H : class where I : class where K : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            return null;
        }
    }

    public class GenericController<A, B, C, D, E, F, G, H, I, K, L> : ControllerBase,
       IGenericController<A, B, C, D, E, F, G, H, I, K, L> where A : class where B : class
       where C : class where D : class where E : class where F : class where G : class where H : class where I : class where K : class where L : class
    {
        private readonly IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K, L> repositoryWrapper;
        public GenericController(IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K, L> wrapper)
        {
            repositoryWrapper = wrapper;
        }

        [HttpPost]
        public virtual Task<ActionResult<A>> AddAsync([FromBody] A value)
        {
            return null;
        }

        [HttpDelete]
        [Authorize]
        public virtual Task<ActionResult<A>> Delete([FromBody] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetAll()
        {
            return null;
        }

        [HttpGet("{search}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search)
        {
            return null;
        }

        [HttpGet("{search}/{start:DateTime}/{end:DateTime}")]
        [Authorize]
        public virtual Task<ActionResult<IEnumerable<A>>> GetBy(string search, DateTime start, DateTime end)
        {
            return null;
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<A>> UpdateAsync([FromBody] A value)
        {
            try
            {
                if (value == null)
                    BadRequest();

                repositoryWrapper.ItemA.Update(value);
                await repositoryWrapper.SaveAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Authorize]
        public virtual Task<ActionResult<A>> PatchUpdateAsync([FromBody] JsonPatchDocument value, [FromHeader] Guid id)
        {
            return null;
        }
    }
}

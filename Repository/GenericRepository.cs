using Contracts;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<A> : IGenericRepository<A> where A : class
    {
        private GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
            this.GestionCommercialContext = GestionCommercialContext;
        }

        //public GenericRepository(GestionCommercialContext gestionCommercialContext)
        //{
        //    this.gestionCommercialContext = gestionCommercialContext;
        //}

        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B> : IGenericRepository<A, B> where A : class where B : class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C> : IGenericRepository<A, B, C> where A : class where B : class where C: class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D> : IGenericRepository<A, B, C, D> where A : class where B : class where C : class where D: class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E> : IGenericRepository<A, B, C, D, E> where A : class where B : class where C : class where D : class where E : class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await GestionCommercialContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F> : IGenericRepository<A, B, C, D, E, F> 
        where A : class where B : class where C : class where D : class where E : class where F : class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await GestionCommercialContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await GestionCommercialContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G> : IGenericRepository<A, B, C, D, E, F, G>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await GestionCommercialContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await GestionCommercialContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await GestionCommercialContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H> : IGenericRepository<A, B, C, D, E, F, G, H>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class where H :class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await GestionCommercialContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await GestionCommercialContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await GestionCommercialContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await GestionCommercialContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H, I> : IGenericRepository<A, B, C, D, E, F, G, H, I>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class where H : class where I : class
    {
        public GestionCommercialContext GestionCommercialContext { get; set; }
        public GenericRepository(GestionCommercialContext GestionCommercialContext)
        {
           this.GestionCommercialContext = GestionCommercialContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await GestionCommercialContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            GestionCommercialContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await GestionCommercialContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            GestionCommercialContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await GestionCommercialContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression)
        {
            return await GestionCommercialContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await GestionCommercialContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await GestionCommercialContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await GestionCommercialContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await GestionCommercialContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await GestionCommercialContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await GestionCommercialContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression)
        {
            return await GestionCommercialContext.Set<I>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await GestionCommercialContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await GestionCommercialContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }
}

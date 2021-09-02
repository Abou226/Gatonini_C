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
        private RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }

        //public GenericRepository(RepositoryContext RepositoryContext)
        //{
        //    this.RepositoryContext = RepositoryContext;
        //}

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B> : IGenericRepository<A, B> where A : class where B : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C> : IGenericRepository<A, B, C> where A : class where B : class where C: class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D> : IGenericRepository<A, B, C, D> where A : class where B : class where C : class where D: class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E> : IGenericRepository<A, B, C, D, E> where A : class where B : class where C : class where D : class where E : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }
        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Where(expression).ToListAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F> : IGenericRepository<A, B, C, D, E, F> 
        where A : class where B : class where C : class where D : class where E : class where F : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G> : IGenericRepository<A, B, C, D, E, F, G>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H> : IGenericRepository<A, B, C, D, E, F, G, H>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class where H :class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await RepositoryContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Where(expression).ToListAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H, I> : IGenericRepository<A, B, C, D, E, F, G, H, I>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class where H : class where I : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
           this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression)
        {
            return await RepositoryContext.Set<I>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await RepositoryContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H, I, J> : IGenericRepository<A, B, C, D, E, F, G, H, I, J>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class where H : class where I : class where J : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression)
        {
            return await RepositoryContext.Set<I>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await RepositoryContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include9, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H, I, J, K> : IGenericRepository<A, B, C, D, E, F, G, H, I, J, K>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class 
        where H : class where I : class where J : class where K : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression)
        {
            return await RepositoryContext.Set<I>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await RepositoryContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include9, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }
    }

    public class GenericRepository<A, B, C, D, E, F, G, H, I, J, K, L> : IGenericRepository<A, B, C, D, E, F, G, H, I, J, K, L>
        where A : class where B : class where C : class where D : class where E : class where F : class where G : class
        where H : class where I : class where J : class where K : class where L : class
    {
        public RepositoryContext RepositoryContext { get; set; }
        public GenericRepository(RepositoryContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }

        public async Task<A> AddAsync(A value)
        {
            await RepositoryContext.Set<A>().AddAsync(value);
            return value;
        }

        public void Delete(A value)
        {
            RepositoryContext.Set<A>().Remove(value);
        }

        public async Task<IEnumerable<A>> GetAll()
        {
            return await RepositoryContext.Set<A>().ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).ToListAsync();
        }

        public void Update(A value)
        {
            RepositoryContext.Set<A>().Update(value);
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include2).Include(include3).Include(include4).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).ToListAsync();
        }

        public virtual Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action)
        {
            return null;
        }

        public async Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression)
        {
            return (IEnumerable<A>)await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).GroupBy(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include2).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include).Include(include1).Include(include3).Include(include4).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5)
        {
            return await RepositoryContext.Set<A>().Include(include).Include(include1).Include(include3).Include(include4).Include(include5).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).ToListAsync();
        }

        public async Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression)
        {
            return await RepositoryContext.Set<B>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression)
        {
            return await RepositoryContext.Set<C>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression)
        {
            return await RepositoryContext.Set<D>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression)
        {
            return await RepositoryContext.Set<E>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression)
        {
            return await RepositoryContext.Set<F>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression)
        {
            return await RepositoryContext.Set<G>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression)
        {
            return await RepositoryContext.Set<I>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression)
        {
            return await RepositoryContext.Set<H>().Where(expression).ToListAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().Where(expression).OrderByDescending(descending).FirstOrDefaultAsync();
        }

        public async Task<A> GetFirst(Expression<Func<A, bool>> ascending)
        {
            return await RepositoryContext.Set<A>().OrderBy(ascending).FirstOrDefaultAsync();
        }

        public async Task<A> GetLast(Expression<Func<A, bool>> descending)
        {
            return await RepositoryContext.Set<A>().OrderBy(descending).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include9, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9)
        {
            return await RepositoryContext.Set<A>().Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9, Expression<Func<A, L>> include10)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).ToListAsync();
        }

        public async Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, J>> include8, Expression<Func<A, K>> include9, Expression<Func<A, L>> include10, Expression<Func<A, bool>> expression)
        {
            return await RepositoryContext.Set<A>().Where(expression).Include(include1).Include(include2).Include(include3).Include(include4).Include(include5).Include(include6).Include(include7).Include(include8).Include(include9).Include(include10).ToListAsync();
        }
    }
}

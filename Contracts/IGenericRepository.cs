using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGenericRepository<A>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetAll(int take);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, int take);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetAll(int take);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, int take);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetAll(int take);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, int take);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);

        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression,Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression,Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F, G>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4);
        Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F, G, H>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression);
        Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5);
        Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6);

        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F, G, H, I>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression);
        Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression);
        Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5);
        Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);

        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F, G, H, I, K>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression);
        Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression);
        Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression);
        Task<IEnumerable<I>> GetByK(Expression<Func<K, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5);
        Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, I>> include6);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, I>> include6, Expression<Func<A, K>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8);

        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }

    public interface IGenericRepository<A, B, C, D, E, F, G, H, I, K, L>
    {
        Task<IEnumerable<A>> GetAll();
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression);
        Task<IEnumerable<B>> GetByB(Expression<Func<B, bool>> expression);
        Task<IEnumerable<C>> GetByC(Expression<Func<C, bool>> expression);
        Task<IEnumerable<D>> GetByD(Expression<Func<D, bool>> expression);
        Task<IEnumerable<E>> GetByE(Expression<Func<E, bool>> expression);
        Task<IEnumerable<F>> GetByF(Expression<Func<F, bool>> expression);
        Task<IEnumerable<G>> GetByG(Expression<Func<G, bool>> expression);
        Task<IEnumerable<H>> GetByH(Expression<Func<H, bool>> expression);
        Task<IEnumerable<I>> GetByI(Expression<Func<I, bool>> expression);
        Task<IEnumerable<K>> GetByK(Expression<Func<K, bool>> expression);
        Task<IEnumerable<L>> GetByL(Expression<Func<L, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, F>> include2, Expression<Func<A, G>> include3, Expression<Func<A, H>> include4);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, H>> include5);
        Task<IEnumerable<A>> GetByIncludeGroup(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, string>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include, Expression<Func<A, D>> include1, Expression<Func<A, E>> include2, Expression<Func<A, F>> include3, Expression<Func<A, G>> include4, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetBy(Expression<Func<A, bool>> expression, Expression<Func<A, B>> include, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, I>> include6);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, I>> include6, Expression<Func<A, K>> include7);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, I>> include6, Expression<Func<A, K>> include7, Expression<Func<A, L>> include8);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, L>> include9);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, bool>> expression);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, L>> include9, Expression<Func<A, bool>> expression);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7);
        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8);

        Task<IEnumerable<A>> GetByInclude(Expression<Func<A, bool>> expression, Expression<Func<A, C>> include1, Expression<Func<A, D>> include2, Expression<Func<A, E>> include3, Expression<Func<A, F>> include4, Expression<Func<A, G>> include5, Expression<Func<A, H>> include6, Expression<Func<A, I>> include7, Expression<Func<A, K>> include8, Expression<Func<A, L>> include9);

        Task<IEnumerable<A>> GetByDescendin(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> descending);
        Task<IEnumerable<A>> GetByAscending(Expression<Func<A, bool>> expression, Expression<Func<A, bool>> ascending);
        Task<A> AddAsync(A value);
        Task<JsonPatchDocument> PatchUpdateAsync(Func<Action> action);
        void Update(A value);
        void Delete(A value);
    }
}

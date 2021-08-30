using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepositoryWrapper<A> : IGenericRepositoryWrapper<A> where A : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A> item;
        public IGenericRepository<A> Item 
        { 
            get
            {
                if (item == null)
                    item = new GenericRepository<A>(repositoryContext);
                return item;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
          await  repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B> : IGenericRepositoryWrapper<A, B> where A : class where B : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<A, B> item;
        public IGenericRepository<A, B> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C> : IGenericRepositoryWrapper<A, B, C> where A : class where B : class where C : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<A, B, C> item;
        public IGenericRepository<A, B, C> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }
        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D> : IGenericRepositoryWrapper<A, B, C, D> where A : class where B : class where C : class where D : class
    {
        private readonly RepositoryContext repositoryContext;


        private IGenericRepository<A, B, C, D> item;
        public IGenericRepository<A, B, C, D> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E> : IGenericRepositoryWrapper<A, B, C, D, E> where A : class where B : class where C : class where D : class where E : class
    {
        private readonly RepositoryContext repositoryContext;


        private IGenericRepository<A, B, C, D, E> item;
        public IGenericRepository<A, B, C, D, E> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F> : IGenericRepositoryWrapper<A, B, C, D, E, F> where A : class where B : class where C : class where D : class where E : class where F : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F> item;
        public IGenericRepository<A, B, C, D, E, F> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F, G> : 
        IGenericRepositoryWrapper<A, B, C, D, E, F, G> where A : class 
        where B : class where C : class where D : class where E : class where F : class where G : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F, G> item;
        public IGenericRepository<A, B, C, D, E, F, G> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F, G>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        private IGenericRepository<G> itemG;
        public IGenericRepository<G> ItemG
        {
            get
            {
                if (itemG == null)
                    itemG = new GenericRepository<G>(repositoryContext);
                return itemG;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F, G, H> :
        IGenericRepositoryWrapper<A, B, C, D, E, F, G, H> where A : class
        where B : class where C : class where D : class where E : class where F : class where G : class where H : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F, G, H> item;
        public IGenericRepository<A, B, C, D, E, F, G, H> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F, G, H>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        private IGenericRepository<G> itemG;
        public IGenericRepository<G> ItemG
        {
            get
            {
                if (itemG == null)
                    itemG = new GenericRepository<G>(repositoryContext);
                return itemG;
            }
        }

        private IGenericRepository<H> itemH;
        public IGenericRepository<H> ItemH
        {
            get
            {
                if (itemH == null)
                    itemH = new GenericRepository<H>(repositoryContext);
                return itemH;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F, G, H, I> :
        IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I> where A : class
        where B : class where C : class where D : class where E : class where F : class where G : class where H : class where I : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F, G, H, I> item;
        public IGenericRepository<A, B, C, D, E, F, G, H, I> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F, G, H, I>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        private IGenericRepository<G> itemG;
        public IGenericRepository<G> ItemG
        {
            get
            {
                if (itemG == null)
                    itemG = new GenericRepository<G>(repositoryContext);
                return itemG;
            }
        }

        private IGenericRepository<H> itemH;
        public IGenericRepository<H> ItemH
        {
            get
            {
                if (itemH == null)
                    itemH = new GenericRepository<H>(repositoryContext);
                return itemH;
            }
        }

        private IGenericRepository<I> itemI;
        public IGenericRepository<I> ItemI
        {
            get
            {
                if (itemI == null)
                    itemI = new GenericRepository<I>(repositoryContext);
                return itemI;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K> :
        IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K> where A : class
        where B : class where C : class where D : class where E : class where F : class where G : class where H : class where I : class where K : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F, G, H, I, K> item;
        public IGenericRepository<A, B, C, D, E, F, G, H, I, K> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F, G, H, I, K>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        private IGenericRepository<G> itemG;
        public IGenericRepository<G> ItemG
        {
            get
            {
                if (itemG == null)
                    itemG = new GenericRepository<G>(repositoryContext);
                return itemG;
            }
        }

        private IGenericRepository<H> itemH;
        public IGenericRepository<H> ItemH
        {
            get
            {
                if (itemH == null)
                    itemH = new GenericRepository<H>(repositoryContext);
                return itemH;
            }
        }

        private IGenericRepository<I> itemI;
        public IGenericRepository<I> ItemI
        {
            get
            {
                if (itemI == null)
                    itemI = new GenericRepository<I>(repositoryContext);
                return itemI;
            }
        }

        private IGenericRepository<K> itemK;
        public IGenericRepository<K> ItemK
        {
            get
            {
                if (itemK == null)
                    itemK = new GenericRepository<K>(repositoryContext);
                return itemK;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }

    public class GenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K, L> :
        IGenericRepositoryWrapper<A, B, C, D, E, F, G, H, I, K, L> where A : class
        where B : class where C : class where D : class where E : class where F : class 
        where G : class where H : class where I : class where K : class where L : class
    {
        private readonly RepositoryContext repositoryContext;

        private IGenericRepository<A, B, C, D, E, F, G, H, I, K, L> item;
        public IGenericRepository<A, B, C, D, E, F, G, H, I, K, L> Item
        {
            get
            {
                if (item == null)
                    item = new GenericRepository<A, B, C, D, E, F, G, H, I, K, L>(repositoryContext);
                return item;
            }
        }

        private IGenericRepository<A> itemA;
        public IGenericRepository<A> ItemA
        {
            get
            {
                if (itemA == null)
                    itemA = new GenericRepository<A>(repositoryContext);
                return itemA;
            }
        }

        private IGenericRepository<B> itemB;
        public IGenericRepository<B> ItemB
        {
            get
            {
                if (itemB == null)
                    itemB = new GenericRepository<B>(repositoryContext);
                return itemB;
            }
        }

        private IGenericRepository<C> itemC;
        public IGenericRepository<C> ItemC
        {
            get
            {
                if (itemC == null)
                    itemC = new GenericRepository<C>(repositoryContext);
                return itemC;
            }
        }

        private IGenericRepository<D> itemD;
        public IGenericRepository<D> ItemD
        {
            get
            {
                if (itemD == null)
                    itemD = new GenericRepository<D>(repositoryContext);
                return itemD;
            }
        }

        private IGenericRepository<E> itemE;
        public IGenericRepository<E> ItemE
        {
            get
            {
                if (itemE == null)
                    itemE = new GenericRepository<E>(repositoryContext);
                return itemE;
            }
        }

        private IGenericRepository<F> itemF;
        public IGenericRepository<F> ItemF
        {
            get
            {
                if (itemF == null)
                    itemF = new GenericRepository<F>(repositoryContext);
                return itemF;
            }
        }

        private IGenericRepository<G> itemG;
        public IGenericRepository<G> ItemG
        {
            get
            {
                if (itemG == null)
                    itemG = new GenericRepository<G>(repositoryContext);
                return itemG;
            }
        }

        private IGenericRepository<H> itemH;
        public IGenericRepository<H> ItemH
        {
            get
            {
                if (itemH == null)
                    itemH = new GenericRepository<H>(repositoryContext);
                return itemH;
            }
        }

        private IGenericRepository<I> itemI;
        public IGenericRepository<I> ItemI
        {
            get
            {
                if (itemI == null)
                    itemI = new GenericRepository<I>(repositoryContext);
                return itemI;
            }
        }

        private IGenericRepository<K> itemK;
        public IGenericRepository<K> ItemK
        {
            get
            {
                if (itemK == null)
                    itemK = new GenericRepository<K>(repositoryContext);
                return itemK;
            }
        }

        private IGenericRepository<L> itemL;
        public IGenericRepository<L> ItemL
        {
            get
            {
                if (itemL == null)
                    itemL = new GenericRepository<L>(repositoryContext);
                return itemL;
            }
        }

        public GenericRepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await repositoryContext.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Nebuteater.Data.Contexts;
using Nebuteater.Data.Infrastructure.Interfaces;

namespace Nebuteater.Data.Infrastructure
{
    public abstract class RepositoryBase<T> 
        where T : class
    {
        private TheatreDbContext context;
        private readonly IDbSet<T> dbSet;

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        protected IDbFactory DbFactory { get; private set; }

        protected TheatreDbContext DbContext => context ?? (context = DbFactory.Init());

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual T Get(int id)
        {
            return dbSet.Find(id);
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }
    }
}
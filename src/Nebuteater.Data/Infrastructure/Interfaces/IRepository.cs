using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Nebuteater.Data.Infrastructure
{
    public interface IRepository<T> 
        where T: class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T Get(int id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
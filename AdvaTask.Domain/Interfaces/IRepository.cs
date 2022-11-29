using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AdvaTask.Domain.Interfaces
{
    public interface IRepository <T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);
        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        T Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        int Count();
        int Count(Expression<Func<T, bool>> criteria);
    }
}

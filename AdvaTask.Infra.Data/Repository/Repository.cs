using System;
using System.Collections.Generic;
using AdvaTask.Domain.Interfaces;

namespace AdvaTask.Infra.Data.Repository
{
    public class Repository<T> :IRepository<T> where T : class
    {
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}

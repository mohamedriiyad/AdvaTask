using System.Collections.Generic;

namespace AdvaTask.Domain.Interfaces
{
    public interface IRepository <T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}

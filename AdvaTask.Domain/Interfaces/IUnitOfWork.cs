
using AdvaTask.Domain.Models;

namespace AdvaTask.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Employee> Employees { get; }
        IRepository<Department> Departments { get; }
        void Complete();
    }
}

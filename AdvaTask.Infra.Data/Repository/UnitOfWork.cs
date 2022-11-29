using AdvaTask.Domain.Interfaces;
using AdvaTask.Domain.Models;
using AdvaTask.Infra.Data.Context;

namespace AdvaTask.Infra.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AdvaContext _context;

        public IRepository<Employee> Employees { get; private set; }
        public IRepository<Department> Departments { get; private set; }
        
        public UnitOfWork(AdvaContext context)
        {
            _context = context;
            
            Employees = new Repository<Employee>(_context);
            Departments = new Repository<Department>(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}

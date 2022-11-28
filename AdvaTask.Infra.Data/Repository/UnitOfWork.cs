using AdvaTask.Domain.Interfaces;
using AdvaTask.Infra.Data.Context;

namespace AdvaTask.Infra.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AdvaContext _context;
        
        public UnitOfWork(AdvaContext context)
        {
            _context = context;
        }


        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}

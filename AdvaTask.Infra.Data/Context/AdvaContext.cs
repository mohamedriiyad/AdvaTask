using AdvaTask.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvaTask.Infra.Data.Context
{
    public class AdvaContext : DbContext
    {
        public AdvaContext(DbContextOptions<AdvaContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

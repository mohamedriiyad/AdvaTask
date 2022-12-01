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
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Department

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey("ManagerId")
                .OnDelete(DeleteBehavior.NoAction)
                .Metadata.IsUnique = true;

            modelBuilder.Entity<Department>()
                 .Property(d => d.Name)
                 .IsRequired();

            #endregion

            #region Employee
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Employee>()
                 .Property(e => e.Name)
                 .IsRequired();

            modelBuilder.Entity<Employee>()
                .HasData(new Employee[] { new Employee { Name = "Manager", Id = 1, Salary = 0 } });
            #endregion
        }
        
    }
}

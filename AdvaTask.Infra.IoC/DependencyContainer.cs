using AdvaTask.Application.Interfaces;
using AdvaTask.Application.ExtensionMethods;
using AdvaTask.Application.Services;
using AdvaTask.Domain.Interfaces;
using AdvaTask.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AdvaTask.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();

            services.AddApplicationCore();
        }
    }
}

using AdvaTask.Application.Interfaces;
using AdvaTask.Application.Services;
using AdvaTask.Domain.Interfaces;
using AdvaTask.Infra.Data.Repository;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdvaTask.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}

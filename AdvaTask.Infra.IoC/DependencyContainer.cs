using AdvaTask.Domain.Interfaces;
using AdvaTask.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AdvaTask.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}

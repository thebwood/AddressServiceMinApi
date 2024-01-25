using Microsoft.EntityFrameworkCore;
using AddressServiceMinApi.Infrastructure.Data;
using AddressServiceMinApi.Infrastructure.Repositories;
using AddressServiceMinApi.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AddressServiceMinApi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string? connectionString)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddDbContext<AddressDbContext>(
                options => options.UseNpgsql(connectionString ?? string.Empty));
                
            return services;
        }

    }
}

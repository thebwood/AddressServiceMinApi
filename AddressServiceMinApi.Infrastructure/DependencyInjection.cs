using AddressServiceMinApi.Infrastructure.Repositories;
using AddressServiceMinApi.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AddressServiceMinApi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();

            return services;
        }

    }
}

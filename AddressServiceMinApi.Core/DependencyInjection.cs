using AddressServiceMinApi.Core.Services;
using AddressServiceMinApi.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace AddressServiceMinApi.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddTransient<IAddressDomainService, AddressDomainService>();

            return services;

        }

    }
}

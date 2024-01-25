﻿namespace AddressServiceMinApi.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, string siteCorsPolicy)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(siteCorsPolicy,
                                   builder =>
                                   {
                                       builder.WithOrigins("http://localhost:7292")
                                                           .AllowAnyHeader()
                                                           .AllowAnyMethod()
                                                           .AllowCredentials();
                                   });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            return services;
        }

    }
}

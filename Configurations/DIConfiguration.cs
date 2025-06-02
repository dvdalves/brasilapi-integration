﻿using BrasilApiIntegration.Interfaces;
using BrasilApiIntegration.Services;

namespace BrasilApiIntegration.Configurations
{
    public static class DIConfiguration
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBrasilApi, BrasilApiService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IBancoService, BancoService>();

            services.AddAutoMapper(typeof(AutoMapper));
        }
    }
}
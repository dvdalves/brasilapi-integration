using BrasilApiIntegration.Interfaces;
using BrasilApiIntegration.Services;

namespace BrasilApiIntegration.Configurations;

public static class DIConfiguration
{
    public static void ConfigureDependencies(this IServiceCollection services)
    {
        services.AddScoped<IBrasilApi, BrasilApiService>();
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IBankService, BankService>();

        services.AddAutoMapper(typeof(AutoMapper));
    }
}
using BetterThanHome.Application.Common.Interfaces.Authentication;
using BetterThanHome.Application.Common.Interfaces.Services;
using BetterThanHome.Infrastructure.Authnetication;
using BetterThanHome.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BetterThanHome.Infrastructure
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            // Add IOption Interface where we can request JWTSettings
            services.Configure<JWTSettings>(configuration.GetSection(JWTSettings.SectionName));

            services.AddSingleton<IJWTokenGenerator, JWTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }

    }
}
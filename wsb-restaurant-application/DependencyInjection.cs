
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_application.Common.Authentication;
using wsb_restaurant_application.Common.Services.Account;
using wsb_restaurant_domain.Models.Entities;
using wsb_restaurant_infrastructure.Authentication;
using Microsoft.Extensions.Configuration;

namespace wsb_restaurant_application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            services.Configure<JwtAppSettings>(configuration.GetSection("JwtSettings"));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}


using Microsoft.Extensions.DependencyInjection;
using wsb_restaurant_application.Services.Authentication;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_dal.Repositories;

namespace wsb_restaurant_application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}

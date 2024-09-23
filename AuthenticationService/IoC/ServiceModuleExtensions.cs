using Catalogue.AuthenticationService.Interfaces;
using Catalogue.AuthenticationService.Repositories;
using Catalogue.AuthenticationService.Services;

namespace Catalogue.AuthenticationService.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuthService, AuthService>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

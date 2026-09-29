using Security.Services;
using Security.Services.Implementation;

namespace Security;

public static class Startup
{
    public static void ConfigureDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}
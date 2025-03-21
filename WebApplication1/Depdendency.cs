using WebApplication1.Services;

namespace WebApplication1;

public static class Dependencies
{
    public static IServiceCollection RegisterDependencies(this IServiceCollection services)
    {
        // Otros
        services.AddHttpClient();
        services.AddHttpContextAccessor();
        services.AddLogging();
        services.AddSingleton<UsuariosServices>();
        return services;
    }
}
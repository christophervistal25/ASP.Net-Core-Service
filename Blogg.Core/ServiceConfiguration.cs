using System.Reflection;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Blogg.Core;

public static class ServiceConfiguration
{
    public static IServiceCollection AddCoreService(this IServiceCollection services)
    {
        var typeAdapterConfig = new TypeAdapterConfig();
        var mappingRegistrations = TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        mappingRegistrations.ToList().ForEach((register) => register.Register(typeAdapterConfig));
        var mappingConfig = new Mapper(typeAdapterConfig);
        // Inject
        services.AddSingleton<IMapper>(mappingConfig);
        return services;
    }
}
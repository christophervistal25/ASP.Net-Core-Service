using Blogg.Core.Post.Commands;
using Blogg.Core.Post.Queries;
using Blogg.Core.Post.Transports;

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Blogg.Core.Post;

public static class ServiceConfiguration
{   
    public static IServiceCollection AddPostService(this IServiceCollection services)
    {
        services.AddScoped(typeof(PostQuery));
        services.AddScoped(typeof(PostCommand));
        return services;
    }
}
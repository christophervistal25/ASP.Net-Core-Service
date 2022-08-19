using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Mapper;
using Blogg.Core.Post.Service;
using Blogg.Core.Post.Transports;
using Microsoft.Extensions.DependencyInjection;

namespace Blogg.Core.Post;

public static class ServiceConfiguration
{
    public static IServiceCollection AddPostConfiguration(this IServiceCollection services)
    {
        services.AddTransient<IPostService, PostService>();
        services.AddTransient<IPostMapper, PostMapper>();
        return services;
    }
}
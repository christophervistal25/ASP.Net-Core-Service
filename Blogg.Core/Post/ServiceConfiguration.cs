using Blogg.Core.Post.Commands;
using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Queries;
using Blogg.Core.Post.Transports;
using Microsoft.Extensions.DependencyInjection;

namespace Blogg.Core.Post;

public static class ServiceConfiguration
{
    public static IServiceCollection AddPostService(this IServiceCollection services)
    {
        services.AddTransient<IGetPostsQuery, GetPostsQuery>();
        services.AddTransient<IAddPostCommand, AddPostCommand>();
        services.AddTransient<IGetPostQuery, GetPostQuery>();
        services.AddTransient<IUpdatePostCommand, UpdatePostCommand>();
        return services;
    }
}
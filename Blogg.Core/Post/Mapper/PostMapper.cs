using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Transports;

namespace Blogg.Core.Post.Mapper;

public class PostMapper : IPostMapper
{
    public Model.Post TransformToEntity(PostTransport transport)
    {
        return new Model.Post
        {
            Id = transport.Id,
            Title = transport.Title,
            Body = transport.Body,
            Thumbnail = transport.Thumbnail
        };
    }

    public PostTransport TransformToPostTransport(Model.Post post)
    {
        return new PostTransport
        {
            Id = post.Id,
            Title = post.Title,
            Body = post.Body,
            Thumbnail = post.Thumbnail
        };
    }

    public IEnumerable<PostTransport> TransformToListOfTransports(List<Model.Post> posts)
    {
        var listOfPostTransports = new List<PostTransport>();
        
        posts.ForEach((post) => listOfPostTransports.Add(TransformToPostTransport(post)));

        return listOfPostTransports;
    }
}

using FluentValidation;
using Mapster;

namespace Blogg.Core.Post.Transports;

public class PostTransport:BaseTransport, IRegister
{
    public string Title { get; set; }
    
    public string Body { get; set; }

    public string Thumbnail { get; set; } = "default_thumbnail.jpg";
    
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Model.Post, PostTransport>();
        config.NewConfig<PostTransport, Model.Post>();
    }
}
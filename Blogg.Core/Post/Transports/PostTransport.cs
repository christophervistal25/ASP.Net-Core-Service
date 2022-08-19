namespace Blogg.Core.Post.Transports;

public class PostTransport:BaseTransport
{
    public string Title { get; set; }
    
    public string Body { get; set; }
    
    public string Thumbnail { get; set; }
}
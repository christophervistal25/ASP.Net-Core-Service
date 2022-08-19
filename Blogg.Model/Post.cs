namespace Blogg.Model;

public class Post : BaseEntity
{
    public string Title { get; set; }
    
    public string Body { get; set; }
    
    public string Thumbnail { get; set; }
}
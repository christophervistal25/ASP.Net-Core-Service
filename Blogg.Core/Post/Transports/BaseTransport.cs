using Blogg.Model;

namespace Blogg.Core.Post.Transports;

public class BaseTransport
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public int IsActive { get; set; } = 1;
}
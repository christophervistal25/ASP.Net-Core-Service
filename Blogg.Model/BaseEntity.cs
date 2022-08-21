using System.ComponentModel.DataAnnotations;

namespace Blogg.Model;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int IsActive { get; set; } = 1;
}
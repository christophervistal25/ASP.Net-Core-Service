using Blogg.Model;
using Microsoft.EntityFrameworkCore;

namespace Blogg.Infrastructure.Contracts;

public interface IApplicationDBContext
{
    public DbSet<Post> Post { get; set; }
}
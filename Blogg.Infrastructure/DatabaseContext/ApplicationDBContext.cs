using Blogg.Infrastructure.Contracts;
using Blogg.Model;
using Microsoft.EntityFrameworkCore;

namespace Blogg.Infrastructure.DatabaseContext;

public class ApplicationDBContext :DbContext, IApplicationDBContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }

    public DbSet<Post> Post { get; set; }
}
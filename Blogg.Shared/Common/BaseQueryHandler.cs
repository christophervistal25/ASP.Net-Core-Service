using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Blogg.Infrastructure.DatabaseContext;
using Blogg.Model;
using MapsterMapper;


namespace Blogg.Shared.Common;

public abstract class BaseQueryHandler<TEntity>
{
   protected readonly IMapper _mapper;
   protected readonly ApplicationDBContext _context;
   
   public BaseQueryHandler(ApplicationDBContext context, IMapper mapper)
   {
      _context = context;
      _mapper = mapper;
   }
   
   public abstract IEnumerable<TEntity> Handle();
   public abstract TEntity Handle(int id);
}  
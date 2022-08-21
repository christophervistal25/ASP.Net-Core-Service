using Blogg.Infrastructure.DatabaseContext;
using Blogg.Model;
using MapsterMapper;

namespace Blogg.Shared.Common;

public abstract class BaseCommandHandler<TEntity>
{
    protected readonly IMapper _mapper;
    protected readonly ApplicationDBContext _context;
   
    public BaseCommandHandler(ApplicationDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public abstract TEntity Handle(TEntity entity);
    public abstract TEntity Handle(TEntity entity, int id);
}
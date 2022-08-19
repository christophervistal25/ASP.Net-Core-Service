using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;
using MapsterMapper;

namespace Blogg.Core.Post.Queries;

public class GetPostsQuery :IGetPostsQuery
{
    private readonly ApplicationDBContext _context;
    private readonly IMapper _mapper;
    public GetPostsQuery(ApplicationDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<PostTransport> Handle()
    {
        var posts = _context.Post.ToList();
        return _mapper.Map<IEnumerable<Model.Post>, List<PostTransport>>(posts);
    }
}
using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;
using MapsterMapper;

namespace Blogg.Core.Post.Queries;

public class GetPostQuery :IGetPostQuery
{
    private readonly ApplicationDBContext _context;
    private readonly IMapper _mapper;
    
    public GetPostQuery(ApplicationDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public PostTransport Handle(int id)
    {
        var post = _context.Post.FirstOrDefault(post => post.Id == id);
        return _mapper.Map<Model.Post, PostTransport>(post);
    }
}
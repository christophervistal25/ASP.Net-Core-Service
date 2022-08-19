using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;
using Blogg.Shared.Contracts;
using Mapster;
using MapsterMapper;

namespace Blogg.Core.Post.Commands;

public class AddPostCommand : IAddPostCommand
{
    private readonly ApplicationDBContext _context;
    private readonly IMapper _mapper;
    public AddPostCommand(ApplicationDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public void Handle(PostTransport entity)
    {
        var post = _mapper.Map<Model.Post>(entity);
        _context.Post.Add(post);
        _context.SaveChanges();
    }
}
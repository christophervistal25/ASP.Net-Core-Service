using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;
using Blogg.Shared.Common;
using MapsterMapper;

namespace Blogg.Core.Post.Commands;

public class PostCommand : BaseCommandHandler<PostTransport>
{

    public PostCommand(ApplicationDBContext context, IMapper mapper) :base(context, mapper)
    {
    }
  
    public override PostTransport Handle(PostTransport entity)
    {
        var post = _mapper.Map<PostTransport, Model.Post>(entity);
        _context.Post.Add(post);
        _context.SaveChanges();

        return entity;
    }

    public override PostTransport Handle(PostTransport entity, int id)
    {
        var post = _mapper.Map<PostTransport, Model.Post>(entity);
        _context.Post.Update(post);
        _context.SaveChanges();

        return entity;
    }
}
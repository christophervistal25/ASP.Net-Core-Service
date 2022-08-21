
using System.Collections;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.Contracts;
using Blogg.Infrastructure.DatabaseContext;
using Blogg.Shared.Common;
using MapsterMapper;

namespace Blogg.Core.Post.Queries;

public class PostQuery :BaseQueryHandler<PostTransport>
{
    public PostQuery(ApplicationDBContext context, IMapper mapper) :base(context, mapper)
    {
    }

    public override IEnumerable<PostTransport> Handle()
    {
        var posts = _context.Post.ToList();
        return _mapper.Map<IEnumerable<Model.Post>, List<PostTransport>>(posts);
    }

    public override PostTransport Handle(int id)
    {
        var post = _context.Post.FirstOrDefault(x => x.Id == id);
        return _mapper.Map<Model.Post, PostTransport>(post!);
    }
}
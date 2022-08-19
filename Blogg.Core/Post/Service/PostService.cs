using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Mapper;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;

namespace Blogg.Core.Post.Service;

public class PostService : IPostService
{
    private readonly ApplicationDBContext _context;
    private readonly IPostMapper _mapper;
    public PostService(ApplicationDBContext context, IPostMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public IEnumerable<PostTransport> Get()
    {
        return _mapper.TransformToListOfTransports(_context.Post.ToList());
    }

    public PostTransport Find(int id)
    {
        return _mapper.TransformToPostTransport(_context.Post.Find(id)!);
    }

    public void Create(PostTransport entity)
    {
        var post = _mapper.TransformToEntity(entity);
        _context.Post.Add(post);
        _context.SaveChanges();
    }

    public void Update(PostTransport entity)
    {
        var post = _mapper.TransformToEntity(entity);
        _context.Post.Update(post);
        _context.SaveChanges();
    }
}
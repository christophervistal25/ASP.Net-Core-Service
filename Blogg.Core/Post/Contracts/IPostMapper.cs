using Blogg.Core.Post.Transports;
using Blogg.Shared.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blogg.Core.Post.Contracts;

public interface IPostMapper : IBaseMapper<PostTransport, Model.Post>
{
 
}
﻿using Blogg.Core.Post.Transports;
using Blogg.Shared.Contracts;

namespace Blogg.Core.Post.Contracts;

public interface IGetPostsQuery : IGetAllCommandHandler<PostTransport>
{
    
}
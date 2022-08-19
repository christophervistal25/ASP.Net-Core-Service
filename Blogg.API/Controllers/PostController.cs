using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogg.Core.Post.Commands;
using Blogg.Core.Post.Contracts;
using Blogg.Core.Post.Transports;
using Blogg.Infrastructure.DatabaseContext;
using Blogg.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blogg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IAddPostCommand _addPostCommand;
        private readonly IGetPostsQuery _getPostsQuery;
        private readonly IGetPostQuery _getPostQuery;
        private readonly IUpdatePostCommand _updatePostCommand;
        public PostController(IGetPostQuery getPostQuery, IAddPostCommand addPostCommand, IGetPostsQuery getPostsQuery, IUpdatePostCommand updatePostCommand)
        {
            _getPostQuery = getPostQuery;
            _addPostCommand = addPostCommand;
            _getPostsQuery = getPostsQuery;
            _updatePostCommand = updatePostCommand;
        }

        [HttpGet(template: nameof(GetPosts), Name = nameof(GetPosts))]
        public ActionResult GetPosts()
        {
            return Ok(_getPostsQuery.Handle());
        }

        [HttpGet(template: nameof(GetPost), Name = nameof(GetPost))]
        public ActionResult GetPost(int id)
        {
            return Ok(_getPostQuery.Handle(id));
        }

        [HttpPost]
        public IActionResult AddPost([FromBody] PostTransport post)
        {
            _addPostCommand.Handle(post);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditPost([FromBody] PostTransport data)
        {
            _updatePostCommand.Handle(data);
            return Ok();
        }

    }
}

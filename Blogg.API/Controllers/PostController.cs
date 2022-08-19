using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IPostService _postService;
        
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet(template: nameof(GetPosts), Name = nameof(GetPosts))]
        public ActionResult GetPosts()
        {
            return Ok(_postService.Get());
        }

        [HttpGet(template: nameof(GetPost), Name = nameof(GetPost))]
        public ActionResult GetPost(int id)
        {
            return Ok(_postService.Find(id));
        }

        [HttpPost]
        public IActionResult AddPost([FromBody] PostTransport post)
        {
            _postService.Create(post);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditPost([FromBody] PostTransport data, int id)
        {
            _postService.Update(data);
            return Ok();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogg.Core.Post.Commands;
using Blogg.Core.Post.Queries;
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

        private readonly PostQuery _postQuery;
        private readonly PostCommand _postCommand;
     
        public PostController(PostQuery postQuery, PostCommand postCommand)
        {
            _postQuery = postQuery;
            _postCommand = postCommand;
        }
        
        [HttpGet(template: nameof(GetPosts), Name = nameof(GetPosts))]
        public ActionResult GetPosts()
        {
            return Ok(_postQuery.Handle());
        }

        [HttpGet(template: nameof(GetPost), Name = nameof(GetPost))]
        public ActionResult GetPost(int id)
        {
            return Ok(_postQuery.Handle(id));
        }

        [HttpPost]
        public IActionResult AddPost([FromBody] PostTransport entity)
        {
            var post = _postCommand.Handle(entity);
            return CreatedAtAction(nameof(GetPost), post);
        }

        [HttpPatch]
        public IActionResult EditPost([FromBody] PostTransport data)
        {
            var post = _postCommand.Handle(data, data.Id);
            return CreatedAtAction(nameof(GetPost), post);
        }

    }
}

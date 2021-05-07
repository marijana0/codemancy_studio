using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task2.Controllers.PostsData;
using Task2.Models;

namespace Task2.Controllers
{
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostData _postData;
        public PostsController(IPostData postData)
        {
            _postData = postData;

        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetPosts()
        {
            return Ok(_postData.GetPosts());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPost(Guid id)
        {
            var post = _postData.GetPost(id);
            var shortPost = new PostDTO()
            {
                Title = post.Title,
                Author = post.Author,
                Date = post.Date,
            };
            if (post != null)
            {
                return Ok(shortPost);
            }
             return NotFound($"The post with id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[controller]/ascending")]
        public IActionResult GetPostsByDateAscending()
        {
            return Ok(_postData.GetPostsByDateAscending());
        }

        [HttpGet]
        [Route("api/[controller]/descending")]
        public IActionResult GetPostsByDateDescending()
        {
            return Ok(_postData.GetPostsByDateDescending());
        }
    }
}
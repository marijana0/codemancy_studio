using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Controllers.PostsData
{
    public interface IPostData
    {
        List<Post> GetPosts();
        Post GetPost(Guid id);

        List<Post> GetPostsByDateAscending();

        List<Post> GetPostsByDateDescending();

    }
}

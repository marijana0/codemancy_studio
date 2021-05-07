using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Task2.Controllers.PostsData;

namespace Task2.Models
{
    public class MockPostData : IPostData
    {
        private List<Post> posts = new List<Post>()
        {
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post1",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/29/2015","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post2",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/29/2016","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post3",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("10/10/2017","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post4",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/28/2020","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post5",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/27/2016","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post6",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/26/2001","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post7",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/25/2014","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post8",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/24/2005","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post9",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/23/2008","MM/dd/yyyy",CultureInfo.InvariantCulture)
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Title="Post10",
                Author="Marijana",
                Content="Quisque sagittis ipsum id nunc ornare, varius volutpat arcu commodo.",
                Date=DateTime.ParseExact("05/22/2009","MM/dd/yyyy",CultureInfo.InvariantCulture)
            }

        };
        //Search by id
        public Post GetPost(Guid id)
        {
            //var post= posts.SingleOrDefault(x => x.Id == id);
            return SearchById.FindPostById(id, posts);
        }

        public List<Post> GetPosts()
        {
            return posts;
        }
        //sort by date ascending
        public List<Post> GetPostsByDateAscending()
        {
            //List<Post> sortedPosts = posts.OrderBy(o => o.Date).ToList();
            var sortedPosts = posts.ToArray();
            SortByDate.Quicksort(sortedPosts,0,(sortedPosts.Length-1));
            return sortedPosts.ToList<Post>();
        }
        //sort by date descending
        public List<Post> GetPostsByDateDescending()
        {
            var sortedPosts = posts.ToArray();
            SortByDate.Quicksort(sortedPosts, 0,(sortedPosts.Length - 1));
            return sortedPosts.Reverse().ToList<Post>();
        }
    }  
}


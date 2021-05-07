using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class SearchById
    {
        public static Post FindPostById(Guid id,List<Post> postsList) {
            foreach (Post p in postsList) {
                if (p.Id == id) return p;
            }
            return null;
        }
    }
}

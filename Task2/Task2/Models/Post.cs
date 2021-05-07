using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Task2.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Content { get; set; }

        public DateTime Date { get; set; }
    }
}

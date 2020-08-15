using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembersOnly.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }
    }
}

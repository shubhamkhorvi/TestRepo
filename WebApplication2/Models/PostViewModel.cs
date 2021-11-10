using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class PostViewModel
    {
        internal int postId;

        public int PostId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }

    }
}

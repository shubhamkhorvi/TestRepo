using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Repository;

namespace WebApplication2.Models
{
    public class PostRepository:IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> { new PostViewModel()
            {
                PostId=101, title="DevOps", description="DevOps Demo", author="john"
            },new PostViewModel()
            {
                PostId=102, title="DevOps2", description="DevOps Demo", author="john"
            },
            new PostViewModel()
            {
                PostId=103, title="DevOps3", description="DevOps Demo", author="john"
            },
            };
            return posts;
        }

    }
}

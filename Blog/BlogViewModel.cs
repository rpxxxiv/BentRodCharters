using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class BlogViewModel
    {
        IBlogRepository repo;

        public BlogViewModel(IBlogRepository repository)
        {
            repo = repository;
        }

        public Blog Blog { get; set; }
        public List<Post> Posts { get; set; }
        public List<UserFeedback> PostFeedback { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog;

namespace FishingGuideSanbox.Repositories
{
    public class BlogRepository:IBlogRepository
    {
        public Blog.Blog GetBlog(Blog.Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostsFor(Blog.Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<UserFeedback> GetUserFeedback(Post post)
        {
            throw new NotImplementedException();
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void AddUserFeedbackToPost(UserFeedback userFeedback)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserFeedback userFeedback)
        {
            throw new NotImplementedException();
        }
    }
}
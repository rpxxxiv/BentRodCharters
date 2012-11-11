using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public interface IBlogRepository
    {
        Blog GetBlog(Blog blog);
        List<Post> GetPostsFor(Blog blog);
        List<UserFeedback> GetUserFeedback(Post post);
        void AddPost(Post post);
        void AddUserFeedbackToPost(UserFeedback userFeedback);
        void UpdatePost(Post post);
        void Delete(Post post);
        void Delete(UserFeedback userFeedback);

    }
}

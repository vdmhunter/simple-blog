using System.Linq;
using SimpleBlog.Data.Infrastructure;
using SimpleBlog.Model;

namespace SimpleBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Post GetPostById(int postId)
        {
            var post = DbContext.Posts.FirstOrDefault(p => p.Id == postId);

            return post;
        }
    }

    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostById(int postId);
    }
}

using SimpleBlog.Data.Infrastructure;
using SimpleBlog.Model;

namespace SimpleBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IPostRepository : IRepository<Post>
    {

    }
}

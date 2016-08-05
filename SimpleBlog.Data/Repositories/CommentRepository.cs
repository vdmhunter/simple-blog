using SimpleBlog.Data.Infrastructure;
using SimpleBlog.Model;

namespace SimpleBlog.Data.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface ICommentRepository : IRepository<Comment>
    {

    }
}

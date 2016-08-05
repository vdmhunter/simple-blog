namespace SimpleBlog.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}

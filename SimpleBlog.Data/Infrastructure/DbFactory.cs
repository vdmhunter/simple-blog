namespace SimpleBlog.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SimpleBlogDbContext _dbContext;

        public SimpleBlogDbContext Init()
        {
            return _dbContext ?? (_dbContext = new SimpleBlogDbContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}

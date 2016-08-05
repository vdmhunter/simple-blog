namespace SimpleBlog.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private SimpleBlogDbContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public SimpleBlogDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}

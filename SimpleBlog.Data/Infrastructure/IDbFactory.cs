using System;

namespace SimpleBlog.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SimpleBlogDbContext Init();
    }
}

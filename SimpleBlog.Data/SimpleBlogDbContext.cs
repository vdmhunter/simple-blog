using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleBlog.Data.Configuration;
using SimpleBlog.Model;

namespace SimpleBlog.Data
{
    public class SimpleBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public SimpleBlogDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        public virtual void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PostConfiguration());
        }

        public static SimpleBlogDbContext Create()
        {
            return new SimpleBlogDbContext();
        }
    }
}

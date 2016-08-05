using System.Data.Entity.ModelConfiguration;
using SimpleBlog.Model;

namespace SimpleBlog.Data.Configuration
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            ToTable("Posts");
            HasMany(e => e.Comments)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);
        }
    }
}
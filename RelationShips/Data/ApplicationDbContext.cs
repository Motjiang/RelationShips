using Microsoft.EntityFrameworkCore;
using RelationShips.Models.Domains;

namespace RelationShips.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        // Add the following DbSet : Images, Posts, Blogs
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}

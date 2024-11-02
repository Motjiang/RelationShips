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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-one relationship between User and Blog
            modelBuilder.Entity<User>()
                .HasOne(u => u.Blog)
                .WithOne(b => b.User)
                .HasForeignKey<User>(u => u.UserId); // Set BlogId as the foreign key

            base.OnModelCreating(modelBuilder);
        }

    }
}

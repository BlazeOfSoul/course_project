using Microsoft.EntityFrameworkCore;

namespace CourseProject.Models
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

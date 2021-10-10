using Microsoft.EntityFrameworkCore;

namespace CourseProject.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(b => b.Posts);
        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

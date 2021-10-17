using Microsoft.EntityFrameworkCore;

namespace CourseProject.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(b => b.Posts);


            modelBuilder.Entity<Answer>()
                .HasOne(p => p.User)
                .WithMany(b => b.Answers)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Answer>()
                .HasOne(p => p.Post)
                .WithMany(b => b.Answers)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

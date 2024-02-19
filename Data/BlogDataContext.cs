using Blog2.Data.Mappings;
using Blog2.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog2.Data
{
  public class BlogDataContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlServer("server=localhost\\sqlexpress;database=Blog;trusted_connection=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
using Microsoft.EntityFrameworkCore;
using RareGroup.Data;
using RareGroup_BE.Data;
using RareGroup_BE.Models;
namespace RareGroup_BE;

public class RareGroup_BEDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }

    public RareGroup_BEDbContext(DbContextOptions<RareGroup_BEDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Send data to Categories table
        modelBuilder.Entity<Category>().HasData(CategoryData.Categories);

        // Sned data to Posts table
        modelBuilder.Entity<Post>().HasData(PostData.Posts);

        // Send data to Tags table
        modelBuilder.Entity<Tag>().HasData(TagData.Tags);

        // Send data to Users table
        modelBuilder.Entity<User>().HasData(UserData.Users);
    }
}
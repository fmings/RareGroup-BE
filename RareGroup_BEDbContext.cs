using Microsoft.EntityFrameworkCore;
using RareGroup_BE.Models;
namespace RareGroup_BE;

public class RareGroup_BEDbContext : DbContext
{
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Posts> Posts { get; set; }
    public DbSet<Tags> Tags { get; set; }
    public DbSet<Users> Users { get; set; }

    public RareGroup_BEDbContext(DbContextOptions<RareGroup_BEDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
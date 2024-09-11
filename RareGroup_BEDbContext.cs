using Microsoft.EntityFrameworkCore;
namespace RareGroup_BE;

public class RareGroup_BEDbContext : DbContext
{
    public RareGroup_BEDbContext(DbContextOptions<RareGroup_BEDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
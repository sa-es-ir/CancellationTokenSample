using Microsoft.EntityFrameworkCore;

namespace CancellationTokenSample.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sample>()
            .ToTable("Test")
            .HasKey(x => x.Id);
    }

    public DbSet<Sample> Samples { get; set; }
}

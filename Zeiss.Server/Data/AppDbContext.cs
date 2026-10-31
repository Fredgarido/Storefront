using Microsoft.EntityFrameworkCore;
using Zeiss.Server.Entities;

namespace Zeiss.Server.Data;

public class AppDbContext : DbContext
{
    public const string ProductIdSequence = "ProductIdSequence";

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Visit ID later
        modelBuilder.HasSequence<int>(ProductIdSequence)
            .StartsAt(100000)
            .IncrementsBy(1)
            .HasMin(100000)
            .HasMax(999999);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
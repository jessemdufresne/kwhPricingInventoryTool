using Microsoft.EntityFrameworkCore;
using kwh.Models;

public class kwhDataContext : DbContext
{
    public kwhDataContext (DbContextOptions<kwhDataContext> options)
        : base(options)
    {
    }

    // DbSet<> properties to set up entity sets (i.e. database table)
    public DbSet<Component> Component { get; set; }
    public DbSet<Maturity> Maturity { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
    public DbSet<AppUser> AppUser { get; set; }
    public DbSet<Category> Category { get; set; }

    // Using EF Core Fluent API...
    // Global changes to override or extend any Data Annotations in Models
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Set Component.Id to auto-increment
        modelBuilder.Entity<Component>(c =>
        {
            c.Property(c => c.Id).ValueGeneratedOnAdd();
        });

        // https://www.learnentityframeworkcore.com/configuration/fluent-api/ondelete-method
        // By default EF Core enables cascade delete for non-nullable FKs 
        // ...resulting in circular cascade delete rules
        // DeleteBehavior.SetNull - FK values in dependent rows will update to NULL

        modelBuilder.Entity<Vendor>()
            .HasMany(c => c.Components)
            .WithOne(v => v.Vendor)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Maturity>()
            .HasMany(c => c.Components)
            .WithOne(m => m.Maturity)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Project>()
            .HasMany(c => c.Components)
            .WithOne(p => p.Project)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Components)
            .WithOne(c => c.Category)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<AppUser>()
            .HasMany(c => c.Components)
            .WithOne(c => c.AppUser)
            .OnDelete(DeleteBehavior.SetNull);

        //modelBuilder.Entity<AppUser>().HasIndex(a => a.Email).IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}
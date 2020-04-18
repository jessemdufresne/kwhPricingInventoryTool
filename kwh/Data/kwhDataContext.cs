using Microsoft.EntityFrameworkCore;

public class kwhDataContext : DbContext
{
    public kwhDataContext (DbContextOptions<kwhDataContext> options)
        : base(options)
    {
    }

    // DbSet<> properties to set up entity sets (i.e. database table)
    public DbSet<kwh.Models.Component> Component { get; set; }
    public DbSet<kwh.Models.Maturity> Maturity { get; set; }
    public DbSet<kwh.Models.Project> Project { get; set; }
    public DbSet<kwh.Models.Vendor> Vendor { get; set; }
    public DbSet<kwh.Models.Volunteer> Volunteer { get; set; }
    public DbSet<kwh.Models.Category> Category { get; set; }

    // Using EF Core Fluent API...
    // Overrides or extends any Data Annotations in Models
    // Specify global changes for Component.Id, set to auto-increment
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<kwh.Models.Component>(c =>
        {
            c.Property(c => c.Id).ValueGeneratedOnAdd();
        });

        // https://www.learnentityframeworkcore.com/configuration/fluent-api/ondelete-method
        // By default EF Core enables cascade delete for non-nullable FKs 
        // ...resulting in circular cascade delete rules
        // DeleteBehavior.Restrict - dependents are unaffected
        // DeleteBehavior.SetNull - FK values in dependent rows should update to NULL

        modelBuilder.Entity<kwh.Models.Vendor>()
            .HasMany(c => c.Components)
            .WithOne(v => v.Vendor)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<kwh.Models.Maturity>()
            .HasMany(c => c.Components)
            .WithOne(m => m.Maturity)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<kwh.Models.Project>()
            .HasMany(c => c.Components)
            .WithOne(p => p.Project)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<kwh.Models.Category>()
            .HasMany(c => c.Components)
            .WithOne(c => c.Category)
            .OnDelete(DeleteBehavior.SetNull);

        base.OnModelCreating(modelBuilder);
    }
}

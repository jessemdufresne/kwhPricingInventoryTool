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

        base.OnModelCreating(modelBuilder);
    }

}

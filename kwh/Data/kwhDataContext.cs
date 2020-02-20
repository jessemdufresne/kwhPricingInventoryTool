using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

    public class kwhDataContext : DbContext
    {
        public kwhDataContext (DbContextOptions<kwhDataContext> options)
            : base(options)
        {
        }

        public DbSet<kwh.Models.Component> Component { get; set; }
        public DbSet<kwh.Models.Maturity> Maturity { get; set; }
        public DbSet<kwh.Models.Project> Project { get; set; }
        public DbSet<kwh.Models.Vendor> Vendor { get; set; }
        public DbSet<kwh.Models.Volunteer> Volunteer { get; set; }
}

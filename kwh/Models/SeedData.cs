using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace kwh.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new kwhDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<kwhDataContext>>()))
            {
                context.Database.EnsureCreated();

                // Check if Maturity table is empty
                // If empty, create test data in arrays and save changes
                if (!context.Maturity.Any())
                {
                    context.Maturity.AddRange(
                    new Maturity { MaturityStatus = "New/Growth" },
                    new Maturity { MaturityStatus = "Mature" },
                    new Maturity { MaturityStatus = "Decline" },
                    new Maturity { MaturityStatus = "Obsolete" }
                    );
                    context.SaveChanges();
                }

                // Check if Project table is empty
                // If empty, create test data in arrays and save changes
                if (!context.Project.Any())
                {
                    context.Project.AddRange(
                    new Project
                    {
                        Name = "Muhuru Bay",
                        Year = 2014,
                        Country = "Kenya"
                    },
                    new Project
                    {
                        Name = "Filibaba",
                        Year = 2015,
                        Country = "Zambia"
                    },
                    new Project
                    {
                        Name = "Chalokwa",
                        Year = 2016,
                        Country = "Zambia"
                    },
                    new Project
                    {
                        Name = "Munyama",
                        Year = 2017,
                        Country = "Zambia"
                    },
                    new Project
                    {
                        Name = "Palawan",
                        Year = 2018,
                        Country = "Philippines"
                    },
                    new Project
                    {
                        Name = "Cheeba",
                        Year = 2019,
                        Country = "Zambia"
                    },
                    new Project
                    {
                        Name = "Kanchomba",
                        Year = 2020,
                        Country = "Zambia"
                    },
                    new Project
                    {
                        Name = "Test",
                        Year = 2020,
                        Country = "Test"
                    });
                    context.SaveChanges();
                }

                // Check if Volunteer table is empty
                // If empty, create test data in arrays and save changes
                if (!context.AppUser.Any())
                {
                    context.AppUser.Add(
                    new AppUser
                    {
                        FirstName = "Test",
                        LastName = "Admin",
                        Email = "admin@admin.com",
                        Username = "admin",
                        Salt = "",
                        PasswordHash = ""
                    });
                    context.SaveChanges();
                }

                // Check if Vendor table is empty
                // If empty, create test data in arrays and save changes
                if (!context.Vendor.Any())
                {
                    context.Vendor.AddRange(
                    new Vendor
                    {
                        Name = "Amazon",
                        Url = "https://www.amazon.com/",
                        Phone = "",
                        Email = "primary@amazon.com"
                    },
                    new Vendor
                    {
                        Name = "Ebay",
                        Url = "https://www.ebay.com/",
                        Phone = "",
                        Email = ""
                    },
                    new Vendor
                    {
                        Name = "Test",
                        Url = "",
                        Phone = "1234567890",
                        Email = "test@test.test"
                    });
                    context.SaveChanges();
                }

                // Check if Category table is empty
                // If empty, create test data in arrays and save changes
                if (!context.Category.Any())
                {
                    context.Category.AddRange(
                    new Category { CategoryName = "Resistor" },
                    new Category { CategoryName = "Converter" },
                    new Category { CategoryName = "GSM Module" },
                    new Category { CategoryName = "Capacitor" },
                    new Category { CategoryName = "Battery" },
                    new Category { CategoryName = "Raspberry Pi" },
                    new Category { CategoryName = "SIM Card" },
                    new Category { CategoryName = "SD Card" },
                    new Category { CategoryName = "Circuit Board" },
                    new Category { CategoryName = "Antenna" },
                    new Category { CategoryName = "Pins" },
                    new Category { CategoryName = "Cable/Wire" },
                    new Category { CategoryName = "Extension Cords" },
                    new Category { CategoryName = "Nuts" },
                    new Category { CategoryName = "Screws" },
                    new Category { CategoryName = "Bolts" });
                    context.SaveChanges();
                }

                // Check if Component table is empty
                // If empty, create test data in arrays and save changes
                if (!context.Component.Any())
                {
                    context.Component.AddRange(
                    new Component
                    {
                        ComponentId = 1,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "MFR-25FBF52-100K",
                        PartName = "RES 100K OHM 1/4W 1% AXIAL",
                        UnitCost = 0.10M,
                        CategoryId = 7, 
                        Notes = "Analog Input Pull-down",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2
                    },
                    new Component
                    {
                        ComponentId = 2,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "WW3FT250",
                        PartName = "RES 250 OHM 3W 1% AXIAL",
                        UnitCost = 0.75M,
                        CategoryId = 7,
                        Notes = "Voltage Reference Shunt Resistor",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 6,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2
                    },
                    new Component
                    {
                        ComponentId = 3,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "1829390",
                        PartName = "TERM BLK HEADER 7POS GREEN",
                        UnitCost = 8.49M,
                        CategoryId = 11,
                        Notes = "7 Position Male Pins Green",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 6,
                        QuantityCurrent = 11,
                        QuantityNeeded = 3
                    },
                    new Component
                    {
                        ComponentId = 4,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "UKL1C100KDD1TD",
                        PartName = "CAP ALUM 10UF 10% 16V RADIAL",
                        UnitCost = 0.40M,
                        CategoryId = 4,
                        Notes = "10uF Capacitor (Hold-up)",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 5
                    },
                    new Component
                    {
                        ComponentId = 5,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Ethernet Extension",
                        UnitCost = 4.95M,
                        CategoryId = 13,
                        Notes = "1 ft. Chord",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1
                    },
                    new Component
                    {
                        ComponentId = 6,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Phoenix Mounting Nuts",
                        UnitCost = 5.88M,
                        CategoryId = 14,
                        Notes = "",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 23,
                        QuantityNeeded = 11
                    },
                    new Component
                    {
                        ComponentId = 7,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "M3 Standoff",
                        UnitCost = 0.63M,
                        CategoryId = 15,
                        Notes = "10 mm",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 6,
                        QuantityCurrent = 17,
                        QuantityNeeded = 16
                    },
                    new Component
                    {
                        ComponentId = 8,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "16GB Micro SD Card",
                        UnitCost = 5.79M,
                        CategoryId = 8,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 4,
                        QuantityCurrent = 3,
                        QuantityNeeded = 1
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

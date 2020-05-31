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
                // If empty, create test data and save changes
                if (!context.Maturity.Any())
                {
                    context.Maturity.AddRange(
                    new Maturity { MaturityStatus = "New" },
                    new Maturity { MaturityStatus = "Mature" },
                    new Maturity { MaturityStatus = "Decline" },
                    new Maturity { MaturityStatus = "Obsolete" }
                    );
                    context.SaveChanges();
                }

                // Check if Project table is empty
                // If empty, create test data and save changes
                if (!context.Project.Any())
                {
                    context.Project.AddRange(
                    new Project
                    {
                        ProjectName = "Muhuru Bay",
                        ProjectYear = 2014,
                        ProjectCountry = "Kenya"
                    },
                    new Project
                    {
                        ProjectName = "Filibaba",
                        ProjectYear = 2015,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Chalokwa",
                        ProjectYear = 2016,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Munyama",
                        ProjectYear = 2017,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Palawan",
                        ProjectYear = 2017,
                        ProjectCountry = "Philippines"
                    },
                    new Project
                    {
                        ProjectName = "Cheeba",
                        ProjectYear = 2019,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Kanchomba",
                        ProjectYear = 2020,
                        ProjectCountry = "Zambia"
                    });
                    context.SaveChanges();
                }

                // Check if Volunteer table is empty
                // If empty, create test data and save changes
                // kwhpitpass
                if (!context.AppUser.Any())
                {
                    context.AppUser.Add(
                    new AppUser
                    {
                        FirstName = "Temp",
                        LastName = "Admin",
                        Email = "temp@admin.com",
                        Username = "temp",
                        Salt = "",
                        PasswordHash = "AQAAAAEAACcQAAAAEAYQRta0AZj7K/eRfRBdaYm3B/i7Wf/sdwNeLjFVxlR29RE8vJMOyPEfw1BB5X92Zg=="
                    });
                    context.SaveChanges();
                }

                // Check if Vendor table is empty
                // If empty, create test data and save changes
                if (!context.Vendor.Any())
                {
                    context.Vendor.AddRange(
                    new Vendor
                    {
                        VendorName = "Amazon",
                        VendorUrl = "https://www.amazon.com/",
                        VendorPhone = "888-280-4331",
                        VendorEmail = "primary@amazon.com"
                    },
                    new Vendor
                    {
                        VendorName = "Ebay",
                        VendorUrl = "https://www.ebay.com/",
                        VendorPhone = "866-540-3229",
                        VendorEmail = ""
                    },
                    new Vendor
                    {
                        VendorName = "Tier1Automation",
                        VendorUrl = "http://www.tier1automation.com/",
                        VendorPhone = "877-648-4371",
                        VendorEmail = "Sales@Tier1Automation.com"
                    },
                    new Vendor
                    {
                        VendorName = "Digi-Key",
                        VendorUrl = "https://www.digikey.com/",
                        VendorPhone = "800-344-4539",
                        VendorEmail = "sales@digikey.com"
                    },
                    new Vendor
                    {
                        VendorName = "Mouser Electronics",
                        VendorUrl = "https://www.mouser.com/",
                        VendorPhone = "800-346-6873",
                        VendorEmail = "sales@mouser.com"
                    },
                    new Vendor
                    {
                        VendorName = "AM Solar",
                        VendorUrl = "https://amsolar.com/",
                        VendorPhone = "541-726-1091",
                        VendorEmail = "info@amsolar.com"
                    },
                    new Vendor
                    {
                        VendorName = "Adafruit",
                        VendorUrl = "https://www.adafruit.com/",
                        VendorPhone = "",
                        VendorEmail = ""
                    });
                    context.SaveChanges();
                }

                // Check if Category table is empty
                // If empty, create test data and save changes
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
                    new Category { CategoryName = "Bolts" },
                    new Category { CategoryName = "Breakers" },
                    new Category { CategoryName = "Circuit" },
                    new Category { CategoryName = "Transducer" },
                    new Category { CategoryName = "Power Strip" });
                    context.SaveChanges();
                }

                // Check if Component table is empty
                // If empty, create test data and save changes
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
                        CategoryId = 13, 
                        Notes = "Analog Input Pull-down",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 2,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "WW3FT250",
                        PartName = "RES 250 OHM 3W 1% AXIAL",
                        UnitCost = 0.75M,
                        CategoryId = 13,
                        Notes = "Voltage Reference Shunt Resistor",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 6,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 3,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "1829390",
                        PartName = "TERM BLK HEADER 7POS GREEN",
                        UnitCost = 8.49M,
                        CategoryId = 9,
                        Notes = "7 Position Male Pins Green",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 6,
                        QuantityCurrent = 11,
                        QuantityNeeded = 3,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 4,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "UKL1C100KDD1TD",
                        PartName = "CAP ALUM 10UF 10% 16V RADIAL",
                        UnitCost = 0.40M,
                        CategoryId = 16,
                        Notes = "10uF Capacitor (Hold-up)",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 5,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 5,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Ethernet Extension",
                        UnitCost = 4.95M,
                        CategoryId = 7,
                        Notes = "1 ft. Chord",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 6,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Phoenix Mounting Nuts",
                        UnitCost = 5.88M,
                        CategoryId = 6,
                        Notes = "",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 23,
                        QuantityNeeded = 11,
                        Timestamp = DateTime.UtcNow
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
                        QuantityNeeded = 16,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 8,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "16GB Micro SD Card",
                        UnitCost = 5.79M,
                        CategoryId = 12,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 4,
                        QuantityCurrent = 3,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.Parse("5/6/2017 13:30:00 PM")
                    },
                    new Component
                    {
                        ComponentId = 8,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "16GB Micro SD Card",
                        UnitCost = 5.53M,
                        CategoryId = 12,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 7,
                        QuantityCurrent = 3,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.Parse("1/6/2020 13:30:00 PM")
                    },
                    new Component
                    {
                        ComponentId = 8,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "16GB Micro SD Card",
                        UnitCost = 5.48M,
                        CategoryId = 12,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 7,
                        QuantityCurrent = 3,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 9,
                        VendorId = 3,
                        AppUserId = 1,
                        PartNumber = "1C05UL",
                        PartName = "0.7A Breakers",
                        UnitCost = 20.65M,
                        CategoryId = 3,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 5,
                        QuantityNeeded = 4,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 10,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Din Rail",
                        UnitCost = 13.15M,
                        Notes = "2-6 inches",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 11,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Voltage Divider",
                        UnitCost = 5.00M,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 12,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Current Transducers",
                        UnitCost = 35.48M,
                        CategoryId = 19,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 3,
                        QuantityNeeded = 2,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 13,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Small Wire Nuts",
                        UnitCost = 4.01M,
                        CategoryId = 6,
                        Notes = "10-001 Wire Gard Gray Wire Connectors, 100-Pack",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 14,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "PCB Screw Terminal Block",
                        UnitCost = 10.60M,
                        CategoryId = 5,
                        Notes = "3 Pole 3 Pin, 5mm Pitch for 14-22AWG Wire",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 3,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 15,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Wiring 500' Cat 5 Cable",
                        UnitCost = 32.00M,
                        CategoryId = 8,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    },
                    new Component
                    {
                        ComponentId = 16,
                        VendorId = 1,
                        AppUserId = 1,
                        PartNumber = "",
                        PartName = "Power Plugstrip",
                        UnitCost = 5.00M,
                        CategoryId = 20,
                        Notes = "",
                        MaturityId = 2,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 1,
                        QuantityNeeded = 1,
                        Timestamp = DateTime.UtcNow
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

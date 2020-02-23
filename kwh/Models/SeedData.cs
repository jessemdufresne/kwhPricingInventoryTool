﻿using Microsoft.EntityFrameworkCore;
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

                // Look for any Maturity.
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

                // Look for any Project.
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
                        ProjectYear = 2014,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Chalokwa",
                        ProjectYear = 2014,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Munyama",
                        ProjectYear = 2014,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Palawan",
                        ProjectYear = 2014,
                        ProjectCountry = "Philippines"
                    },
                    new Project
                    {
                        ProjectName = "Cheeba",
                        ProjectYear = 2014,
                        ProjectCountry = "Zambia"
                    },
                    new Project
                    {
                        ProjectName = "Kanchomba",
                        ProjectYear = 2014,
                        ProjectCountry = "Zambia"
                    });
                    context.SaveChanges();
                }

                // Look for any Volunteer.
                if (!context.Volunteer.Any())
                {
                    context.Volunteer.AddRange(
                    new Volunteer
                    {
                        FirstName = "Daniel",
                        LastName = "Nausner",
                        VolunteerPhone = "206-735-1989",
                        VolunteerEmail = "dan.nausner@gmail.com",
                    },
                    new Volunteer
                    {
                        FirstName = "Jeremiah",
                        LastName = "Kalmus",
                        VolunteerPhone = "425-354-7471 ",
                        VolunteerEmail = "jeremiah.kalmus@gmail.com",
                    });
                    context.SaveChanges();
                }

                // Look for any Vendor.
                if (!context.Vendor.Any())
                {
                    context.Vendor.AddRange(
                    new Vendor
                    {
                        VendorName = "Amazon",
                        VendorUrl = "https://www.amazon.com/",
                        VendorPhone = "",
                        VendorEmail = "primary@amazon.com"
                    },
                    new Vendor
                    {
                        VendorName = "Ebay",
                        VendorUrl = "https://www.ebay.com/",
                        VendorPhone = "",
                        VendorEmail = ""
                    });
                    context.SaveChanges();
                }

                // Look for any Category.
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

                // Look for any Component.
                if (!context.Component.Any())
                {
                    context.Component.AddRange(
                    new Component
                    {
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
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

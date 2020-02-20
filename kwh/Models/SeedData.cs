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

                // Look for any movies.
                if (context.Component.Any())
                {
                    return;  // DB has been seeded
                }

                context.Maturity.AddRange(
                    new Maturity { MaturityStatus = "New/Growth" },
                    new Maturity { MaturityStatus = "Mature" },
                    new Maturity { MaturityStatus = "Decline" },
                    new Maturity { MaturityStatus = "Obsolete" }
                    );
                context.SaveChanges();

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

                context.Volunteer.AddRange(
                    new Volunteer
                    {
                        FirstName = "Daniel",
                        LastName = "Nausner",
                        VolunteerPhone = "206-735-1989",
                        VolunteerEmail = "dan.nausner@gmail.com",
                        PIN = 1989
                    },
                    new Volunteer
                    {
                        FirstName = "Jeremiah",
                        LastName = "Kalmus",
                        VolunteerPhone = "425-354-7471 ",
                        VolunteerEmail = "jeremiah.kalmus@gmail.com",
                        PIN = 7471
                    });
                context.SaveChanges();

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

                context.Component.AddRange(
                    new Component
                    {
                        ComponentId = 1,
                        Historic = 1,
                        Current = 1,
                        VendorId = 1,
                        VolunteerId = 1,
                        PartNumber = "UBEC 5A",
                        PartName = "Hobbywing UBEC 5V 5A",
                        UnitCost = 6.19M,
                        Specification = "6-30V Input/5V 3A Output Power Supply",
                        MaturityId = 1,
                        Url = "",
                        ProjectId = 5,
                        QuantityCurrent = 2,
                        QuantityNeeded = 2,
                        TimeStamp = DateTime.Now
                    }) ;
                context.SaveChanges();
            }
        }
    }
}

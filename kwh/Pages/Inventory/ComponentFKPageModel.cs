using System;
using kwh.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// Tutorial from https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/update-related-data?view=aspnetcore-3.1
// Creates and populates drop down lists for Inventory CRUD scaffolding
namespace kwh.Pages.Inventory
{
    public class ComponentFKPageModel : PageModel
    {
        /* Create multiple SelectLists to contain the list of FK details
         * If selectedMaturity, selectedProject, selectedVendor,
         * selectedVolunteer or selectedCategory is specified, that corresponding
         * FK detail.
         *
         * Inventory Create and Edit pages model classes will derive from the
         * ComponentFKPageModel class. 
        */
        public SelectList MaturityStatusSL { get; set; }
        public SelectList ProjectNameSL { get; set; }
        public SelectList VendorNameSL { get; set; }
        public SelectList LastNameSL { get; set; }
        public SelectList CategoryNameSL { get; set; }

        public void PopulateMaturityDropDown(kwhDataContext _context,
            object selectedMaturity = null)
        {
            var maturityQuery = from m in _context.Maturity
                                orderby m.Id
                                select m;

            MaturityStatusSL = new SelectList(maturityQuery.AsNoTracking(),
                        "MaturityId", "MaturityStatus", selectedMaturity);

        }

        public void PopulateProjectDropDown(kwhDataContext _context,
            object selectedProject = null)
        {
            var projectQuery = from p in _context.Project
                               orderby p.Year
                               select p;

            ProjectNameSL = new SelectList(projectQuery.AsNoTracking(),
                        "ProjectId", "Name", selectedProject);
        }

        public void PopulateVendorDropDown(kwhDataContext _context,
            object selectedVendor = null)
        {
            var vendorQuery = from v in _context.Vendor
                              orderby v.Name
                              select v;

            VendorNameSL = new SelectList(vendorQuery.AsNoTracking(),
                        "VendorId", "Name", selectedVendor);
        }

        public void PopulateUserDropDown(kwhDataContext _context,
            object selectedUser = null)
        {
            var userQuery = from v in _context.AppUser
                                 orderby v.LastName
                                 select v;

            LastNameSL = new SelectList(userQuery.AsNoTracking(),
                        "AppUserId", "LastName", selectedUser);
        }

        public void PopulateCategoryDropDown(kwhDataContext _context,
            object selectedCategory = null)
        {
            var categoryQuery = from c in _context.Category
                                orderby c.CategoryName
                                select c;

            CategoryNameSL = new SelectList(categoryQuery.AsNoTracking(),
                        "CategoryId", "CategoryName", selectedCategory);
        }
    }
}

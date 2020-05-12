using System;
using kwh.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// Create and populate drop down lists for Inventory scaffolding
namespace kwh.Pages.Inventory
{
    public class ComponentFKPageModel : PageModel
    {
        // Each SelectList contains its corresponding FK detail
        // Inventory/Create and Inventory/Edit inherits ComponentFKPageModel class
        public SelectList MaturityStatusSL { get; set; }
        public SelectList ProjectNameSL { get; set; }
        public SelectList VendorNameSL { get; set; }
        public SelectList UserNameSL { get; set; }
        public SelectList CategoryNameSL { get; set; }

        public void PopulateMaturityDropDown(kwhDataContext _context,
            object selectedMaturity = null)
        {
            var maturityQuery = from m in _context.Maturity
                                orderby m.MaturityId
                                select m;

            MaturityStatusSL = new SelectList(maturityQuery.AsNoTracking(),
                        "MaturityId", "MaturityStatus", selectedMaturity);

        }

        public void PopulateProjectDropDown(kwhDataContext _context,
            object selectedProject = null)
        {
            var projectQuery = from p in _context.Project
                               orderby p.ProjectYear
                               select p;

            ProjectNameSL = new SelectList(projectQuery.AsNoTracking(),
                        "ProjectId", "ProjectName", selectedProject);
        }

        public void PopulateVendorDropDown(kwhDataContext _context,
            object selectedVendor = null)
        {
            var vendorQuery = from v in _context.Vendor
                              orderby v.VendorName
                              select v;

            VendorNameSL = new SelectList(vendorQuery.AsNoTracking(),
                        "VendorId", "VendorName", selectedVendor);
        }

        public void PopulateUserDropDown(kwhDataContext _context,
            object selectedUser = null)
        {
            var userQuery = from v in _context.AppUser
                            orderby v.Username
                            select v;

            UserNameSL = new SelectList(userQuery.AsNoTracking(),
                        "AppUserId", "UserName", selectedUser);
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

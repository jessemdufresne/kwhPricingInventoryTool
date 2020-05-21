using System;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Inventory
{
    // Derives ComponentFKPageModel to load FK navigation properties 
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly kwhDataContext _context;
        public CreateModel(kwhDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Component Component { get; set; }

        [BindProperty]
        public string datetime { get; set; }

        public SelectList MaturityStatusSL { get; set; }
        public SelectList ProjectNameSL { get; set; }
        public SelectList VendorNameSL { get; set; }
        public SelectList UserNameSL { get; set; }
        public SelectList CategoryNameSL { get; set; }

        // Select FK navigation properties to populate drop down fields
        public IActionResult OnGet()
        {
            var projectQuery = _context.Project
                .OrderBy(p => p.ProjectYear)
                .Select(p => p);

            var vendorQuery = _context.Vendor
                .OrderBy(v => v.VendorName)
                .Select(v => v);

            var categoryQuery = _context.Category
                .OrderBy(c => c.CategoryName)
                .Select(c => c);

            var userQuery = _context.AppUser
                .OrderBy(u => u.Username)
                .Select(u => u);

            MaturityStatusSL = new SelectList(_context.Maturity.AsNoTracking(),
                nameof(Maturity.MaturityId), nameof(Maturity.MaturityStatus));
            ProjectNameSL = new SelectList(projectQuery.AsNoTracking(),
                nameof(Project.ProjectId), nameof(Project.ProjectName));
            VendorNameSL = new SelectList(vendorQuery.AsNoTracking(),
                nameof(Vendor.VendorId), nameof(Vendor.VendorName));
            UserNameSL = new SelectList(userQuery.AsNoTracking(),
                nameof(AppUser.Id), nameof(AppUser.Username));
            CategoryNameSL = new SelectList(categoryQuery.AsNoTracking(),
                nameof(Category.CategoryId), nameof(Category.CategoryName));
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // 1) Retrieve the maximum ComponentId to increment
            // New records should use the next available ComponentId
            // Uses EF Core LINQ-to-Entities Method Syntax
            var compId = _context.Component
                .OrderByDescending(x => x.ComponentId)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Retrieve user input
            if (ModelState.IsValid)
            {
                // 3) Manually increment ComponentId and set Timestamp input
                Component.ComponentId = compId + 1;
                Component.Timestamp = DateTime.Parse(datetime);
                _context.Component.Add(Component);
                // 4) Save changes to the database
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            var projectQuery = _context.Project
                .OrderBy(p => p.ProjectYear)
                .Select(p => p);

            var vendorQuery = _context.Vendor
                .OrderBy(v => v.VendorName)
                .Select(v => v);

            var categoryQuery = _context.Category
                .OrderBy(c => c.CategoryName)
                .Select(c => c);

            var userQuery = _context.AppUser
                .OrderBy(u => u.Username)
                .Select(u => u);

            // Select FK navigation properties for drop down fields if
            // TryUpdateModelAsync fails
            MaturityStatusSL = new SelectList(_context.Maturity,
                nameof(Maturity.MaturityId), nameof(Maturity.MaturityStatus),
                Component.MaturityId);
            ProjectNameSL = new SelectList(projectQuery,
                nameof(Project.ProjectId), nameof(Project.ProjectName),
                Component.ProjectId);
            VendorNameSL = new SelectList(vendorQuery,
                nameof(Vendor.VendorId), nameof(Vendor.VendorName),
                Component.VendorId);
            UserNameSL = new SelectList(userQuery,
                nameof(AppUser.Id), nameof(AppUser.Username),
                Component.AppUserId);
            CategoryNameSL = new SelectList(categoryQuery,
                nameof(Category.CategoryId), nameof(Category.CategoryName),
                Component.CategoryId);
            return Page();
        }
    }
}

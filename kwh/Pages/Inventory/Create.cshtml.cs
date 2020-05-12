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

        [BindProperty]
        public Component Component { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyComponent = new Component();

            // 1) Retrieve the maximum ComponentId to increment
            // New records should use the next available ComponentId
            // Uses EF Core LINQ-to-Entities Method Syntax
            var compId = _context.Component
                .OrderByDescending(x => x.ComponentId)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Asynchronously retrieve user input
            // TryUpdateModelAsync prevents overposting
            if (await TryUpdateModelAsync<Component>(
                 emptyComponent,
                 "component",   // Prefix for form value.
                 c => c.PartNumber, c => c.PartName, c => c.CategoryId, c => c.VendorId,
                 c => c.UnitCost, c => c.Notes, c => c.MaturityId, c => c.Url,
                 c => c.QuantityCurrent, c => c.QuantityNeeded, c => c.ProjectId, c => c.AppUserId))
            {
                // 3) Manually increment ComponentId before adding a new record
                emptyComponent.ComponentId = compId + 1;
                _context.Component.Add(emptyComponent);
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
                emptyComponent.MaturityId);
            ProjectNameSL = new SelectList(projectQuery,
                nameof(Project.ProjectId), nameof(Project.ProjectName),
                emptyComponent.ProjectId);
            VendorNameSL = new SelectList(vendorQuery,
                nameof(Vendor.VendorId), nameof(Vendor.VendorName),
                emptyComponent.VendorId);
            UserNameSL = new SelectList(userQuery,
                nameof(AppUser.Id), nameof(AppUser.Username),
                emptyComponent.AppUserId);
            CategoryNameSL = new SelectList(categoryQuery,
                nameof(Category.CategoryId), nameof(Category.CategoryName),
                emptyComponent.CategoryId);
            return Page();
        }
    }
}

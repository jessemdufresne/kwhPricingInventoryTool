using System;
using System.Collections.Generic;
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
    // Derives ComponentFKPageModel to load FK navigation properties in drop down
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly kwhDataContext _context;
        public EditModel(kwhDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Component Component { get; set; }

        public string Category = "";
        public List<string> CategoryList;
        public SelectList MaturityStatusSL { get; set; }
        public SelectList ProjectNameSL { get; set; }
        public SelectList VendorNameSL { get; set; }
        public SelectList UserNameSL { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the Component object corresponding to the selected Id
            Component = await _context.Component
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.AppUser)
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Component == null)
            {
                return NotFound();
            }

            var projectQuery = _context.Project
                .OrderBy(p => p.ProjectYear)
                .Select(p => p);

            var vendorQuery = _context.Vendor
                .OrderBy(v => v.VendorName)
                .Select(v => v);

            var userQuery = _context.AppUser
                .OrderBy(u => u.Username)
                .Select(u => u);

            var maturityQuery = _context.Maturity
               .OrderBy(x => x.MaturityId)
               .Select(m => m);

            CategoryList = _context.Category
                .Select(x => x.CategoryName)
                .ToList();

            // Select existing FK navigation properties for drop down fields
            MaturityStatusSL = new SelectList(maturityQuery.AsNoTracking(),
                nameof(Maturity.MaturityId), nameof(Maturity.MaturityStatus));
            ProjectNameSL = new SelectList(projectQuery.AsNoTracking(),
                nameof(Project.ProjectId), nameof(Project.ProjectName));
            VendorNameSL = new SelectList(vendorQuery.AsNoTracking(),
                nameof(Vendor.VendorId), nameof(Vendor.VendorName));
            UserNameSL = new SelectList(userQuery.AsNoTracking(),
                nameof(AppUser.Id), nameof(AppUser.Username));
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Create a new Component object to insert into the database
            var emptyComponent = new Component();

            // 1) Retrieve the ComponentId corresponding to the selected Id
            // "Updating" will insert a new record (i.e. increment Id and use same ComponentId)
            // EF Core LINQ-to-Entities Method Syntax
            var compId = _context.Component
                .Where(x => x.Id == id)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Asynchronously retrieve user input
            if (await TryUpdateModelAsync<Component>(
                 emptyComponent,
                 "component",
                 c => c.PartNumber, c => c.PartName, c => c.CategoryId, c => c.VendorId,
                 c => c.UnitCost, c => c.Notes, c => c.MaturityId, c => c.Url,
                 c => c.QuantityCurrent, c => c.QuantityNeeded, c => c.ProjectId, c => c.AppUserId))
            {
                // 3) Manually assign the same ComponentId before adding a new record
                emptyComponent.ComponentId = compId;
                emptyComponent.Timestamp = DateTime.UtcNow;
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

            var userQuery = _context.AppUser
                .OrderBy(u => u.Username)
                .Select(u => u);

            var maturityQuery = _context.Maturity
               .OrderBy(x => x.MaturityId)
               .Select(m => m);

            CategoryList = _context.Category
                .Select(x => x.CategoryName)
                .ToList();

            // Select FK navigation properties for drop down fields if TryUpdateModelAsync fails
            MaturityStatusSL = new SelectList(maturityQuery,
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
            return Page();
        }
    }
}

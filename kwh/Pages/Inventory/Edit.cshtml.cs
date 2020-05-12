using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Inventory
{
    // Derives ComponentFKPageModel to load FK navigation properties in drop down
    [Authorize]
    public class EditModel : ComponentFKPageModel
    {
        private readonly kwhDataContext _context;
        public EditModel(kwhDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Component Component { get; set; }

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

            // Select existing FK navigation properties for drop down fields
            PopulateVendorDropDown(_context, Component.VendorId);
            PopulateMaturityDropDown(_context, Component.MaturityId);
            PopulateProjectDropDown(_context, Component.ProjectId);
            PopulateUserDropDown(_context, Component.AppUserId);
            PopulateCategoryDropDown(_context, Component.CategoryId);
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
                _context.Component.Add(emptyComponent);
                // 4) Save changes to the database
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select FK navigation properties for drop down fields if TryUpdateModelAsync fails
            PopulateVendorDropDown(_context, emptyComponent.VendorId);
            PopulateMaturityDropDown(_context, emptyComponent.MaturityId);
            PopulateProjectDropDown(_context, emptyComponent.ProjectId);
            PopulateUserDropDown(_context, emptyComponent.AppUserId);
            PopulateCategoryDropDown(_context, emptyComponent.CategoryId);
            return Page();
        }
    }
}

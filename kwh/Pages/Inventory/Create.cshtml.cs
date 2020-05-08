using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace kwh.Pages.Inventory
{
    // Derives ComponentFKPageModel to load FK navigation properties in drop down
    [Authorize]
    public class CreateModel : ComponentFKPageModel
    {
        private readonly kwhDataContext _context;

        public CreateModel(kwhDataContext context)
        {
            _context = context;
        }

        // Select FK navigation properties for drop down fields
        public IActionResult OnGet()
        {
            PopulateVendorDropDown(_context);
            PopulateMaturityDropDown(_context);
            PopulateProjectDropDown(_context);
            PopulateUserDropDown(_context);
            PopulateCategoryDropDown(_context);
            return Page();
        }

        [BindProperty]
        public Component Component { get; set; }

        // TryUpdateModelAsync prevents overposting
        // To protect from overposting attacks, enable specific bind properties
        // More details at https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyComponent = new Component();

            // New additions to the Component table should use the next available ComponentId
            // 1) Retrieve the maximum ComponentId to increment
            // ** EF Core LINQ-to-Entities Query (written in method syntax) **
            var compId = _context.Component
                .OrderByDescending(x => x.ComponentId)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Asynchronously retrieve user input
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

            // Select FK navigation properties for drop down fields if
            // TryUpdateModelAsync fails
            PopulateVendorDropDown(_context, emptyComponent.VendorId);
            PopulateMaturityDropDown(_context, emptyComponent.MaturityId);
            PopulateProjectDropDown(_context, emptyComponent.ProjectId);
            PopulateUserDropDown(_context, emptyComponent.AppUserId);
            PopulateCategoryDropDown(_context, emptyComponent.CategoryId);
            return Page();
        }
    }
}

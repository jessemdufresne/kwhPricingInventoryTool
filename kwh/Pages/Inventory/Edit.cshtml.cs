using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Inventory
{
    // Derives ComponentFKPageModel to load FK navigation properties in drop down
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
                .Include(c => c.Volunteer)
                .Include(c => c.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Component == null)
            {
                return NotFound();
            }

            // Select existing FK navigation properties for drop down fields
            PopulateVendorDropDown(_context, Component.VendorId);
            PopulateMaturityDropDown(_context, Component.MaturityId);
            PopulateProjectDropDown(_context, Component.ProjectId);
            PopulateVolunteerDropDown(_context, Component.VolunteerId);
            PopulateCategoryDropDown(_context, Component.CategoryId);
            return Page();
        }

        // TryUpdateModelAsync prevents overposting
        // To protect from overposting attacks, enable specific bind properties
        // More details at https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Create a new Component object to insert into the database
            var emptyComponent = new Component();
            // 1) Retrieve the Component object corresponding to the selected Id
            var componentToUpdate = await _context.Component.FindAsync(id);

            // "Updates" to a component, should insert a new record (i.e. increment PK Id and use same ComponentId) 
            // 2) Retrieve the ComponentId corresponding to the selected Id
            // ** EF Core LINQ-to-Entities Query (written in method syntax) **
            var compId = _context.Component
                .Where(x => x.Id == id)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Asynchronously retrieve user input
            if (await TryUpdateModelAsync<Component>(
                 emptyComponent,
                 "component",   // Prefix for form value.
                 c => c.PartNumber, c => c.PartName, c => c.CategoryId, c => c.VendorId,
                 c => c.UnitCost, c => c.Notes, c => c.MaturityId, c => c.Url,
                 c => c.QuantityCurrent, c => c.QuantityNeeded, c => c.ProjectId, c => c.VolunteerId))
            {
                // 3) Manually set the same ComponentId before adding a new record
                emptyComponent.ComponentId = compId;
                _context.Component.Add(emptyComponent);
                // 4) Save changes to the database
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select FK navigation properties for drop down fields if
            // TryUpdateModelAsync fails
            PopulateVendorDropDown(_context, componentToUpdate.VendorId);
            PopulateMaturityDropDown(_context, componentToUpdate.MaturityId);
            PopulateProjectDropDown(_context, componentToUpdate.ProjectId);
            PopulateVolunteerDropDown(_context, componentToUpdate.VolunteerId);
            PopulateCategoryDropDown(_context, componentToUpdate.CategoryId);
            return Page();
        }
    }
}

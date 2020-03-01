using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

namespace kwh.Pages.Inventory
{
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

            PopulateVendorDropDown(_context, Component.VendorId);
            PopulateMaturityDropDown(_context, Component.MaturityId);
            PopulateProjectDropDown(_context, Component.ProjectId);
            PopulateVolunteerDropDown(_context, Component.VolunteerId);
            PopulateCategoryDropDown(_context, Component.CategoryId);
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emptyComponent = new Component();
            var componentToUpdate = await _context.Component.FindAsync(id);

            // Retrieve ComponentId corresponding to the PK
            var compId = _context.Component
                .Where(x => x.Id == id)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            if (await TryUpdateModelAsync<Component>(
                 emptyComponent,
                 "component",   // Prefix for form value.
                 c => c.PartNumber, c => c.PartName, c => c.CategoryId, c => c.VendorId,
                 c => c.UnitCost, c => c.Notes, c => c.MaturityId, c => c.Url,
                 c => c.QuantityCurrent, c => c.QuantityNeeded, c => c.ProjectId, c => c.VolunteerId))
            {
                emptyComponent.ComponentId = compId;
                _context.Component.Add(emptyComponent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select FK IDs if TryUpdateModelAsync fails.
            PopulateVendorDropDown(_context, componentToUpdate.VendorId);
            PopulateMaturityDropDown(_context, componentToUpdate.MaturityId);
            PopulateProjectDropDown(_context, componentToUpdate.ProjectId);
            PopulateVolunteerDropDown(_context, componentToUpdate.VolunteerId);
            PopulateCategoryDropDown(_context, componentToUpdate.CategoryId);
            return Page();
        }
    }
}

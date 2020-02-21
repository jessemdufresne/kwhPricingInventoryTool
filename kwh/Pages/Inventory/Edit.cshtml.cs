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
                .Include(c => c.Volunteer).FirstOrDefaultAsync(m => m.ComponentId == id);

            if (Component == null)
            {
                return NotFound();
            }

            PopulateVendorDropDown(_context, Component.VendorId);
            PopulateMaturityDropDown(_context, Component.MaturityId);
            PopulateProjectDropDown(_context, Component.ProjectId);
            PopulateVolunteerDropDown(_context, Component.VolunteerId);
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

            var componentToUpdate = await _context.Component.FindAsync(id);

            if (componentToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Component>(
                 componentToUpdate,
                 "edit_component",   // Prefix for form value.
                 c => c.PartNumber, c => c.PartName, c => c.VendorId, c => c.UnitCost,
                 c => c.Specification, c => c.MaturityId, c => c.Url, c => c.QuantityCurrent,
                 c => c.QuantityNeeded, c => c.ProjectId, c => c.VolunteerId))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulateVendorDropDown(_context, componentToUpdate.VendorId);
            PopulateMaturityDropDown(_context, componentToUpdate.MaturityId);
            PopulateProjectDropDown(_context, componentToUpdate.ProjectId);
            PopulateVolunteerDropDown(_context, componentToUpdate.VolunteerId);
            return Page();
        }
    }
}

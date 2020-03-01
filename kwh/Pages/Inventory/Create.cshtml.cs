using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using kwh.Models;

namespace kwh.Pages.Inventory
{
    public class CreateModel : ComponentFKPageModel
    {
        private readonly kwhDataContext _context;

        public CreateModel(kwhDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateVendorDropDown(_context);
            PopulateMaturityDropDown(_context);
            PopulateProjectDropDown(_context);
            PopulateVolunteerDropDown(_context);
            PopulateCategoryDropDown(_context);
            return Page();
        }

        [BindProperty]
        public Component Component { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyComponent = new Component();

            // Retrieve max ComponentId
            var compId = _context.Component
                .OrderByDescending(x => x.ComponentId)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            compId += 1;

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
            PopulateVendorDropDown(_context, emptyComponent.VendorId);
            PopulateMaturityDropDown(_context, emptyComponent.MaturityId);
            PopulateProjectDropDown(_context, emptyComponent.ProjectId);
            PopulateVolunteerDropDown(_context, emptyComponent.VolunteerId);
            PopulateCategoryDropDown(_context, emptyComponent.CategoryId);
            return Page();
        }
    }
}

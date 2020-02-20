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
    public class EditModel : PageModel
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
           ViewData["MaturityId"] = new SelectList(_context.Set<Maturity>(), "MaturityId", "MaturityId");
           ViewData["ProjectId"] = new SelectList(_context.Set<Project>(), "ProjectId", "ProjectId");
           ViewData["VendorId"] = new SelectList(_context.Set<Vendor>(), "VendorId", "VendorId");
           ViewData["VolunteerId"] = new SelectList(_context.Set<Volunteer>(), "VolunteerId", "VolunteerId");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Component).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComponentExists(Component.ComponentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ComponentExists(int id)
        {
            return _context.Component.Any(e => e.ComponentId == id);
        }
    }
}

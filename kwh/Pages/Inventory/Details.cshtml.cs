using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

namespace kwh.Pages.Inventory
{
    public class DetailsModel : PageModel
    {
        private readonly kwhDataContext _context;

        public DetailsModel(kwhDataContext context)
        {
            _context = context;
        }

        public Component Component { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Component = await _context.Component
                .AsNoTracking()
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer).FirstOrDefaultAsync(m => m.ComponentId == id);

            if (Component == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

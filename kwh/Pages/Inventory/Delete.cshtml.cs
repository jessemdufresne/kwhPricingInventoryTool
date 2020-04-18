using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

// DELETING deletes by Id, which should be the most recent record of the component
// When it is the only record of the component, it deletes the component from the table altogether

namespace kwh.Pages.Inventory
{
    public class DeleteModel : PageModel
    {
        private readonly kwhDataContext _context;

        public DeleteModel(kwhDataContext context)
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
                .AsNoTracking()
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer)
                .Include(c => c.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Component == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // 1) Retrieve the Component object corresponding to the selected Id
            Component = await _context.Component.FindAsync(id);

            if (Component != null)
            {
                _context.Component.Remove(Component);
                // 2) Save changes to the database
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Inventory
{
    public class DetailsModel : PageModel
    {
        private readonly kwhDataContext _context;

        public DetailsModel(kwhDataContext context)
        {
            _context = context;
        }

        public PaginatedList<Component> Component { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, int? pageIndex)
        {
            if (id == null)
            {
                return NotFound();
            }

            // 1) Retrieve the ComponentId corresponding to the selected Id
            // ** EF Core LINQ-to-Entities Query (written in method syntax) **
            var compId = _context.Component
                .Where(x => x.Id == id)
                .Select(x => x.ComponentId)
                .FirstOrDefault();

            // 2) Retrieve all historical records for the selected ComponentId ordered by timestamp
            // ** EF Core LINQ-to-Entities Query (written in method syntax) **
            IQueryable<Component> components = _context.Component
                .Where(x => x.ComponentId == compId)
                .OrderByDescending(x => x.Timestamp)
                .Select(c => c);

            int pageSize = 10; // Number of records shown per page
            Component = await PaginatedList<Component>.CreateAsync(
                components
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer)
                .Include(c => c.Category).AsNoTracking(),
                pageIndex ?? 1, pageSize);

            if (Component == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

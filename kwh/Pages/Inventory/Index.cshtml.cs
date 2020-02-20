using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kwh.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace kwh.Pages.Inventory
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        public IList<Component> Component { get;set; }
        /*[BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Project { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PartName { get; set; }
        */
        public async Task OnGetAsync()
        {
            Component = await _context.Component
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer).ToListAsync();
        }
    }
}

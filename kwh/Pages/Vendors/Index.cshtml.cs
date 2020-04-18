using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Vendors
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        // Add properties to contain searching and filtering parameters
        [BindProperty]
        public string SearchBy { get; set; }
        public string CurrentFilter { get; set; }

        // Add properties to contain sorting parameters
        public string VendorSort { get; set; }
        public string CurrentSort { get; set; }

        public IList<Vendor> Vendor { get;set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter
            , string searchby, string searchString)
        {
            CurrentSort = sortOrder;

            VendorSort = String.IsNullOrEmpty(sortOrder) ? "cat_desc" : "";

            if (searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;
            SearchBy = searchby;

            IQueryable<Vendor> vendors = from v in _context.Vendor
                                              select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                vendors = vendors
                        .Where(c => c.VendorName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "cat_desc":
                    vendors = vendors.OrderByDescending(c => c.VendorName);
                    break;
                default:
                    vendors = vendors.OrderBy(c => c.VendorName);
                    break;
            }

            Vendor = await vendors.AsNoTracking().ToListAsync();
        }
    }
}

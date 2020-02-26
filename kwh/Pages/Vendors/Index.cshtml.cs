using System;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
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

        public string VendorSort { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Vendor> Vendor { get;set; }

        public async Task OnGetAsync(string sortOrder, int? pageIndex)
        {
            CurrentSort = sortOrder;

            VendorSort = String.IsNullOrEmpty(sortOrder) ? "cat_desc" : "";

            IQueryable<Vendor> vendors = from v in _context.Vendor
                                              select v;

            switch (sortOrder)
            {
                case "cat_desc":
                    vendors = vendors.OrderByDescending(c => c.VendorName);
                    break;
                default:
                    vendors = vendors.OrderBy(c => c.VendorName);
                    break;
            }

            int pageSize = 8;
            Vendor = await PaginatedList<Vendor>.CreateAsync(
                vendors.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

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

        public string NameSort { get; set; }
        public string QuantitySort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Component> Component { get;set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            QuantitySort = sortOrder == "Quantity" ? "quan_desc" : "Quantity";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Component> components = from c in _context.Component
                                               select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                components = components.Where(c => c.PartName.ToUpper().Contains(searchString.ToUpper())
                || c.PartNumber.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    components = components.OrderByDescending(c => c.PartName);
                    break;
                case "Quantity":
                    components = components.OrderBy(c => c.QuantityCurrent);
                    break;
                case "quan_desc":
                    components = components.OrderByDescending(c => c.QuantityCurrent);
                    break;
                default:
                    components = components.OrderBy(c => c.PartName);
                    break;
            }

            int pageSize = 3;
            Component = await PaginatedList<Component>.CreateAsync(
                components
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer).AsNoTracking(),
                pageIndex ?? 1, pageSize);
        }
    }
}

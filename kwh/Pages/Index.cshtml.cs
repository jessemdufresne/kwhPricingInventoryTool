using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using kwh.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using kwh.Pages.Inventory;

namespace kwh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public string NameSort { get; set; }
        public string QuantitySort { get; set; }
        public string CostSort { get; set; }
        public string ProjectSort { get; set; }
        public string CategorySort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        [BindProperty]
        public string SearchBy { get; set; }
        public string[] Criteria = new[] { "Category", "Part", "Project" };

        public PaginatedList<Component> Component { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchby, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            QuantitySort = sortOrder == "Quantity" ? "quan_desc" : "Quantity";
            CostSort = sortOrder == "Cost" ? "cost_desc" : "Cost";
            ProjectSort = sortOrder == "Project" ? "proj_desc" : "Project";
            CategorySort = sortOrder == "Category" ? "cat_desc" : "Category";

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
                if (searchby == "Category")
                {
                    components = components.Where(c => c.Category.CategoryName
                    .ToUpper().Contains(searchString.ToUpper()));

                }
                else if (searchby == "Part")
                {
                    components = components.Where(c => c.PartName.ToUpper()
                    .Contains(searchString.ToUpper()) || c.PartNumber.ToUpper()
                    .Contains(searchString.ToUpper()));
                }
                else
                {
                    components = components.Where(c => c.Project.ProjectName
                    .ToUpper().Contains(searchString.ToUpper()));
                }

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
                case "Cost":
                    components = components.OrderBy(c => c.UnitCost);
                    break;
                case "cost_desc":
                    components = components.OrderByDescending(c => c.UnitCost);
                    break;
                case "Project":
                    components = components.OrderBy(c => c.Project.ProjectName);
                    break;
                case "proj_desc":
                    components = components.OrderByDescending(c => c.Project.ProjectName);
                    break;
                case "Category":
                    components = components.OrderBy(c => c.Category.CategoryName);
                    break;
                case "cat_desc":
                    components = components.OrderByDescending(c => c.Category.CategoryName);
                    break;
                default:
                    components = components.OrderBy(c => c.PartName);
                    break;
            }

            int pageSize = 5;
            Component = await PaginatedList<Component>.CreateAsync(
                components
                .Include(c => c.Maturity)
                .Include(c => c.Project)
                .Include(c => c.Vendor)
                .Include(c => c.Volunteer)
                .Include(c => c.Category).AsNoTracking(),
                pageIndex ?? 1, pageSize);
        }
    }
}

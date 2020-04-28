using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Categories
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
        public string CategorySort { get; set; }
        public string CurrentSort { get; set; }

        public IList<Category> Category { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter
            , string searchby, string searchString)
        {
            CurrentSort = sortOrder;

            CategorySort = String.IsNullOrEmpty(sortOrder) ? "cat_desc" : "";

            if (searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;
            SearchBy = searchby;

            IQueryable<Category> categories = from c in _context.Category
                                               select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                categories = categories
                        .Where(c => c.CategoryName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "cat_desc":
                    categories = categories.OrderByDescending(c => c.CategoryName);
                    break;
                default:
                    categories = categories.OrderBy(c => c.CategoryName);
                    break;
            }

            Category = await categories.AsNoTracking().ToListAsync();
        }
    }
}

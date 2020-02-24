using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

namespace kwh.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        public string CategorySort { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Category> Category { get; set; }

        public async Task OnGetAsync(string sortOrder, int? pageIndex)
        {
            CurrentSort = sortOrder;

            CategorySort = String.IsNullOrEmpty(sortOrder) ? "cat_desc" : "";

            IQueryable<Category> categories = from c in _context.Category
                                               select c;

            switch (sortOrder)
            {
                case "cat_desc":
                    categories = categories.OrderByDescending(c => c.CategoryName);
                    break;
                default:
                    categories = categories.OrderBy(c => c.CategoryName);
                    break;
            }

            int pageSize = 8;
            Category = await PaginatedList<Category>.CreateAsync(
                categories.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

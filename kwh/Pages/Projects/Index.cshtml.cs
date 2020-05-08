using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Projects
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
        public string NameSort { get; set; }
        public string YearSort { get; set; }
        public string CurrentSort { get; set; }
         
        public IList<Project> Project { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter
            , string searchby, string searchString)
        {
            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            YearSort = sortOrder == "Year" ? "year_desc" : "Year";

            if (searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;
            SearchBy = searchby;

            IQueryable<Project> projects = from p in _context.Project
                                             select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                projects = projects
                        .Where(c => c.Name.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    projects = projects.OrderByDescending(p => p.Name);
                    break;
                case "Year":
                    projects = projects.OrderBy(c => c.Year);
                    break;
                case "year_desc":
                    projects = projects.OrderByDescending(c => c.Year);
                    break;
                default:
                    projects = projects.OrderBy(p => p.Name);
                    break;
            }

            Project = await projects.AsNoTracking().ToListAsync();
        }
    }
}

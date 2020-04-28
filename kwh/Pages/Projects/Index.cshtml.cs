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
                        .Where(c => c.ProjectName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    projects = projects.OrderByDescending(p => p.ProjectName);
                    break;
                case "Year":
                    projects = projects.OrderBy(c => c.ProjectYear);
                    break;
                case "year_desc":
                    projects = projects.OrderByDescending(c => c.ProjectYear);
                    break;
                default:
                    projects = projects.OrderBy(p => p.ProjectName);
                    break;
            }

            Project = await projects.AsNoTracking().ToListAsync();
        }
    }
}

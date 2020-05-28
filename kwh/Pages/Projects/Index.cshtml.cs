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

            // Toggle column sorting
            YearSort = String.IsNullOrEmpty(sortOrder) ? "year_desc" : "";
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";


            if (searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;
            SearchBy = searchby;

            IQueryable<Project> projects = _context.Project;

            if (!String.IsNullOrEmpty(searchString))
            {
                projects = projects
                        .Where(c => c.ProjectName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "year_desc":
                    projects = projects.OrderByDescending(p => p.ProjectYear);
                    break;
                case "Name":
                    projects = projects.OrderBy(c => c.ProjectName);
                    break;
                case "name_desc":
                    projects = projects.OrderByDescending(c => c.ProjectName);
                    break;
                default:
                    projects = projects.OrderBy(p => p.ProjectYear);
                    break;
            }

            Project = await projects.AsNoTracking().ToListAsync();
        }
    }
}

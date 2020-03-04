using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

namespace kwh.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string YearSort { get; set; }
        public string CurrentSort { get; set; }
         
        public PaginatedList<Project> Project { get; set; }

        public async Task OnGetAsync(string sortOrder, int? pageIndex)
        {
            CurrentSort = sortOrder;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            YearSort = sortOrder == "Year" ? "year_desc" : "Year";

            IQueryable<Project> project = from p in _context.Project
                                             select p;

            switch (sortOrder)
            {
                case "name_desc":
                    project = project.OrderByDescending(p => p.ProjectName);
                    break;
                case "Year":
                    project = project.OrderBy(c => c.ProjectYear);
                    break;
                case "year_desc":
                    project = project.OrderByDescending(c => c.ProjectYear);
                    break;
                default:
                    project = project.OrderBy(p => p.ProjectName);
                    break;
            }

            int pageSize = 10;
            Project = await PaginatedList<Project>.CreateAsync(
                project.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kwh.Models;

namespace kwh.Pages.Volunteers
{
    public class IndexModel : PageModel
    {
        private readonly kwhDataContext _context;

        public IndexModel(kwhDataContext context)
        {
            _context = context;
        }

        // Add properties to contain sorting parameters
        public string LastSort { get; set; }
        public string CurrentSort { get; set; }

        public IList<Volunteer> Volunteer { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;

            LastSort = String.IsNullOrEmpty(sortOrder) ? "last_desc" : "";

            IQueryable<Volunteer> volunteers = _context.Volunteer;

            switch (sortOrder)
            {
                case "last_desc":
                    volunteers = volunteers.OrderByDescending(c => c.LastName);
                    break;
                default:
                    volunteers = volunteers.OrderBy(c => c.LastName);
                    break;
            }

            Volunteer = await volunteers.AsNoTracking().ToListAsync();
        }
    }
}

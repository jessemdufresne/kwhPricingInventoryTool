using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.AppUsers
{
    [Authorize]
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

        public IList<AppUser> AppUser { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;

            // Toggle sorting
            LastSort = String.IsNullOrEmpty(sortOrder) ? "last_desc" : "";

            IQueryable<AppUser> users = _context.AppUser;

            switch (sortOrder)
            {
                case "last_desc":
                    users = users.OrderByDescending(c => c.LastName);
                    break;
                default:
                    users = users.OrderBy(c => c.LastName);
                    break;
            }

            AppUser = await users.AsNoTracking().ToListAsync();
        }
    }
}

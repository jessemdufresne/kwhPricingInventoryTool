using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kwh.Pages.Volunteers
{
    public class CreateModel : PageModel
    {
        private readonly kwhDataContext _context;

        public CreateModel(kwhDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Volunteer Volunteer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Volunteer.Add(Volunteer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

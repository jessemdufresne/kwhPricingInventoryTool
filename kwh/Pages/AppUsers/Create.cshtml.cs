using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using kwh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CryptoHelper;

namespace kwh.Pages.AppUsers
{
    [Authorize]
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
        public AppUser AppUser { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userId = _context.AppUser
                .Where(u => u.Email.Contains(AppUser.Email.ToLower()))
                .Select(u => u.Id)
                .FirstOrDefault();

            // If there is no existing email, add a new user
            if (userId == 0)
            {

                // Manually set properties before adding a new record
                AppUser.Email = AppUser.Email.ToLower();
                AppUser.Username = AppUser.Email.Substring(0, Math.Max(AppUser.Email.IndexOf('@'), 0));
                AppUser.Salt = "";

                var hashedPassword = HashPassword(AppUser.Password);
                AppUser.PasswordHash = hashedPassword;
                _context.AppUser.Add(AppUser);

                // Save changes to the database
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException e)
                {
                    if (e.InnerException != null)
                    {
                        throw new DbUpdateException("InnerException:", e.InnerException);
                    }
                    throw new InvalidOperationException("DbUpdateException occurred creating a new user.");
                }
                return RedirectToPage("./Index");
            }
            else
            {
                ModelState.AddModelError("CustomErr", "User or email already exisits.");
                return Page();
            }
        }

        // Hash a password
        public string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }
    }
}

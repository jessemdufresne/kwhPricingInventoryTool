using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CryptoHelper;
using kwh.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kwh.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly kwhDataContext _context;
        public LoginModel(kwhDataContext context)
        {
            _context = context;
        }

        public class InputModel
        {
            [Required]
            [Display(Name = "Username/Email")]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [StringLength(14, ErrorMessage = "Must be between 8 and 14 characters.", MinimumLength = 8)]
            public string Password { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clears existing external cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {

                // Authenticate with salt hashing
                var user = await AuthenticateUser(Input.Username, Input.Password);

                if (user == null)
                {
                    ModelState.AddModelError("CustomErr", "Invalid login attempt.");
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim("Email", user.Email),
                    new Claim(ClaimTypes.Role, "Administrator"),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, 
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        // Allows user to refresh the auth session
                        AllowRefresh = true,
                        // Sets auth ticket to expire in 25 mins
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(25),
                        // Persists auth session across multiple requests
                        IsPersistent = true,
                    });

                if (!Url.IsLocalUrl(returnUrl)) returnUrl = Url.Content("~/");
                return LocalRedirect(returnUrl);
            }

            // Failed: redisplay the page
            return Page();
        }

        private async Task<AppUser> AuthenticateUser(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            // Check if user exists in db
            var user = await _context.AppUser
                .AsNoTracking()
                .Where(v => v.Email.Contains(login))
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            // User was not found
            if (user == null) { return null; }

            // Compare given password and stored password hash
            if (VerifyPassword(user.PasswordHash, password))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        // Verify the password hash against the given password
        private bool VerifyPassword(string hash, string password)
        {
            return Crypto.VerifyHashedPassword(hash, password);
        }
    }
}

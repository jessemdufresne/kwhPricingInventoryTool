using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using kwh.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CryptoHelper;

namespace kwh.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly kwhDataContext _context;
        public LoginModel(kwhDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

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

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {

                var user = await AuthenticateUser(Input.Username, Input.Password);

                if (user == null)
                {
                    ModelState.AddModelError("CustomErr", "Invalid login attempt.");
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
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
                        // Refreshing the authentication session should be allowed.
                        AllowRefresh = true,
                        // Aauthentication ticket expires in 25 mins
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(25),
                        // Auth session is persisted across multiple requests
                        IsPersistent = true,
                    });

                return LocalRedirect("/inventory");
            }

            // Something failed. Redisplay the form.
            return Page();
        }

        private async Task<AppUser> AuthenticateUser(string login, string password)
        {
            // For demonstration purposes, authenticate a user
            // with a static email address. Ignore the password.
            // Assume that checking the database takes 500ms
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            var lower_login = login.Contains("@")
                ? login.ToLower() : login.Substring(0, Math.Max(login.IndexOf('@'), 0)).ToLower();
            var user = await _context.AppUser
                .AsNoTracking()
                .Where(v => v.Email.Contains(lower_login))
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            if (user == null) { return null; }


            if (VerifyPassword(user.PasswordHash, HashPassword(password)))
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

        // Hash a password
        private string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }
    }
}

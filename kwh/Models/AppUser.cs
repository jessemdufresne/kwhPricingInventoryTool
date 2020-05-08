using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [StringLength(32)]
        public string Email { get; set; }

        public string Username { get; set; }

        public string Salt { get; set; } = "";

        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [NotMapped]
        [DataType(DataType.Password)]
        [StringLength(14, ErrorMessage = "Must be between 8 and 14 characters", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }

        [Display(Name = "First")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string VolunteerPhone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string VolunteerEmail { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}
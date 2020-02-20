using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }
        [Display(Name = "First")]
        public string FirstName { get; set; }
        [Display(Name = "Last")]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        public string VolunteerPhone { get; set; }
        [Display(Name = "Email")]
        public string VolunteerEmail { get; set; }
        public int PIN { get; set; }

        public ICollection<Component> Components { get; set; }
    }
}
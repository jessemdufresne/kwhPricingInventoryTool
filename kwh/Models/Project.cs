using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Project")]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Country { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }

}

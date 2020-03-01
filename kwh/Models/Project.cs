using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Project
    {
        // EF Core Data Annotations

        public int ProjectId { get; set; }

        [Display(Name = "Project")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string ProjectName { get; set; }

        [Display(Name = "Year")]
        [Required]
        public int ProjectYear { get; set; }

        [Display(Name = "Country")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string ProjectCountry { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }

}

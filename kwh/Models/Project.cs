using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Project")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int ProjectYear { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string ProjectCountry { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }

}

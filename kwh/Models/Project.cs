using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Project
    {
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

        public ICollection<Component> Components { get; set; }
    }

}

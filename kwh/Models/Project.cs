using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Project")]
        [StringLength(25, MinimumLength = 3)]
        public string ProjectName { get; set; }

        [Required]
        public int ProjectYear { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string ProjectCountry { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }

}

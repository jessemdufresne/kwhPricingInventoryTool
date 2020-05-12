using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Maturity
    {
        [Key]
        public int MaturityId { get; set; }

        [Required]
        [Display(Name = "Maturity")]
        [StringLength(25, MinimumLength = 3)]
        public string MaturityStatus { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }
}

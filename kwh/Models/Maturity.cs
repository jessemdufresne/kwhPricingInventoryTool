using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Maturity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Maturity")]
        [StringLength(25, MinimumLength = 3)]
        public string MaturityStatus { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}

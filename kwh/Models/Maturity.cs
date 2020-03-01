using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Maturity
    {
        // EF Core Data Annotations

        public int MaturityId { get; set; }

        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string MaturityStatus { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}

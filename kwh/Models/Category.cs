using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string CategoryName { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}
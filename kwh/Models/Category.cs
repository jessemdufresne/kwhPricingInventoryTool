using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Navigation property holds related entities in a 1:M
        public ICollection<Component> Components { get; set; }
    }
}

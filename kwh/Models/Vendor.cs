using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string VendorName { get; set; }

        [DataType(DataType.Url)]
        public string VendorUrl { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string VendorPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string VendorEmail { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }
}

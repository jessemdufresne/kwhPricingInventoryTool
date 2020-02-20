using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }

        [Display(Name = "Vendor")]
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string VendorName { get; set; }

        [Display(Name = "URL")]
        [DataType(DataType.Url)]
        public string VendorUrl { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string VendorPhone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string VendorEmail { get; set; }

        public ICollection<Component> Components { get; set; }
    }
}

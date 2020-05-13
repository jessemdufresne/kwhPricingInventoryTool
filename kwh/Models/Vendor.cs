using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kwh.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }

        [Required]
        [Display(Name = "Vendor")]
        public string VendorName { get; set; }

        [Display(Name = "URL")]
        [Url(ErrorMessage = "Url is invalid. Must contain 'http://' or 'https://'")]
        public string VendorUrl { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string VendorPhone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string VendorEmail { get; set; }

        // Navigation property holds related 1:M entities
        public ICollection<Component> Components { get; set; }
    }
}
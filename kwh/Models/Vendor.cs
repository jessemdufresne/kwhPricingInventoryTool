using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Display(Name = "Vendor")]
        public string VendorName { get; set; }
        [Display(Name = "URL")]
        public string VendorUrl { get; set; }
        [Display(Name = "Phone")]
        public string VendorPhone { get; set; }
        [Display(Name = "Email")]
        public string VendorEmail { get; set; }

        public ICollection<Component> Components { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Component
    {
        public int ComponentId { get; set; }
        public int Historic { get; set; }
        public int Current { get; set; }

        [Display(Name = "Vendor")]
        public int VendorId { get; set; }
        [Display(Name = "Volunteer")]
        public int VolunteerId { get; set; }
        [Display(Name = "Maturity")]
        public int MaturityId { get; set; }
        [Display(Name = "Project")]
        public int ProjectId { get; set; }
        public Vendor Vendor { get; set; }
        public Volunteer Volunteer { get; set; }
        public Maturity Maturity { get; set; }
        public Project Project { get; set; }

        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }
        [Display(Name = "Part Name")]
        public string PartName { get; set; }
        [Display(Name = "Unit Cost")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }
        [Display(Name = "Description")]
        public string Specification { get; set; }
        public string Url { get; set; }
        [Display(Name = "Current Quantity")]
        public int QuantityCurrent { get; set; }
        [Display(Name = "Quantity Needed")]
        public int QuantityNeeded { get; set; }
        [Display(Name = "Last Modified")]
        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; }
    }
}

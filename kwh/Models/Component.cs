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
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Vendor Vendor { get; set; }
        public Volunteer Volunteer { get; set; }
        public Maturity Maturity { get; set; }
        public Project Project { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Part Number")]
        [StringLength(25, MinimumLength = 3)]
        public string PartNumber { get; set; }

        [Display(Name = "Part Name")]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string PartName { get; set; }

        [Display(Name = "Unit Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }

        [StringLength(40, MinimumLength = 3)]
        public string Notes { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [Display(Name = "Current Quantity")]
        public int QuantityCurrent { get; set; }

        [Display(Name = "Quantity Needed")]
        public int QuantityNeeded { get; set; }

        [Display(Name = "Last Modified")]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime TimeStamp { get; set; }
        //.Computed is for Add and Update actions...
        //.Identity for Add action only
    }
}

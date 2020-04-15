using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Using EF Core Data Annotations

namespace kwh.Models
{
    public class Component
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ComponentId { get; set; }

        // Set foreign keys and corresponding navigation properties
        // to hold related entities of a 1:M relationship
        [Display(Name = "Vendor")]
        public int? VendorId { get; set; }

        [Display(Name = "Volunteer")]
        [Required]
        public int VolunteerId { get; set; }

        [Display(Name = "Maturity")]
        public int? MaturityId { get; set; }

        [Display(Name = "Project")]
        public int? ProjectId { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

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

        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Timestamp { get; set; }
        //.Identity for Add action only
        //.Computed is for Add and Update actions...
    }
}
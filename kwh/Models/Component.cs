using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Component
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ComponentId { get; set; }

        // Set FKs to hold related 1:M entities
        [Display(Name = "Vendor")]
        public int? VendorId { get; set; }

        [Display(Name = "User")]
        public int? AppUserId { get; set; }

        [Display(Name = "Maturity")]
        public int? MaturityId { get; set; }

        [Display(Name = "Project")]
        public int? ProjectId { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        public Vendor Vendor { get; set; }

        [Display(Name = "User")]
        public AppUser AppUser { get; set; }
        public Maturity Maturity { get; set; }
        public Project Project { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }

        [Required]
        [Display(Name = "Part Name")]
        public string PartName { get; set; }

        [Display(Name = "Unit Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }

        public string Notes { get; set; }

        [Url(ErrorMessage = "Url is invalid. Must contain 'http://' or 'https://'")]
        public string Url { get; set; }

        [Required]
        [Display(Name = "Current Quantity")]
        public int QuantityCurrent { get; set; }

        [Display(Name = "Quantity Needed")]
        public int QuantityNeeded { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [NotMapped]
        [Required]
        [Display(Name = "Date Added")]
        public bool isCurrent { get; set; }
    }
}

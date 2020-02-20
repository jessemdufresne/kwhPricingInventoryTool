using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kwh.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Display(Name = "Project")]
        public string ProjectName { get; set; }
        [Display(Name = "Year")]
        public int ProjectYear { get; set; }
        [Display(Name = "Country")]
        public string ProjectCountry { get; set; }

        public ICollection<Component> Components { get; set; }
    }

}

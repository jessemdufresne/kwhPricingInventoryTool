using System.Collections.Generic;

namespace kwh.Models
{
    public class Maturity
    {
        public int MaturityId { get; set; }
        public string MaturityStatus { get; set; }

        public ICollection<Component> Components { get; set; }
    }
}

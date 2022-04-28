using System.Collections.Generic;

namespace DMS.Entities
{
    public class TrafficType
    {
        public TrafficType()
        {
            Tradods = new HashSet<Tradod>();
        }

        public int ID { get; set; }
        public string TrafficTypeTitle { get; set; }

        public virtual ICollection<Tradod> Tradods { get; set; }
    }
}

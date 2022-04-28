using System.Collections.Generic;

namespace DMS.Entities
{
    public class Destination
    {
        public Destination()
        {
            Tradods = new HashSet<Tradod>();
        }

        public int ID { get; set; }
        public string DestinationTitle { get; set; }

        public virtual ICollection<Tradod> Tradods { get; set; }
    }
}
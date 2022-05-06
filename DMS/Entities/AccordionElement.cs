using System.Collections.Generic;

namespace DMS.Entities
{
    public class AccordionElement
    {
        public AccordionElement()
        {
            ElementUsers = new HashSet<ElementUser>();
        }

        public int ID { get; set; }
        public string AccTag { get; set; }
        public string AccStr { get; set; }
        public string EleTag { get; set; }
        public string EleStr { get; set; }


        public virtual ICollection<ElementUser> ElementUsers { get; set; }

    }
}
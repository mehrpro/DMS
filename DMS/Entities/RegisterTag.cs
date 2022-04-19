using System.Collections.Generic;

namespace DMS.Entities
{
    public class RegisterTag
    {

        public RegisterTag()
        {
            Tagrecives = new HashSet<Tagrecive>();
        }

        public int ID { get; set; }
        public int StudentID_FK { get; set; }
        public Student Student { get; set; }
        public int TagID_FK { get; set; }
        public Tag Tag { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Tagrecive> Tagrecives { get; set; }

    }
}

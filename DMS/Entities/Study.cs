using System.Collections.Generic;

namespace DMS.Entities
{
    public class Study
    {
        public Study()
        {
            Students = new HashSet<Student>();
        }
        public int ID { get; set; }
        public string StudyTitle { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

using System.Collections.Generic;

namespace DMS.Entities
{
    public class EducationalCenter
    {

        public EducationalCenter()
        {
            Students = new HashSet<Student>();
        }
        public int ID { get; set; }
        public string EducationalName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Student> Students { get; set; }



    }
}

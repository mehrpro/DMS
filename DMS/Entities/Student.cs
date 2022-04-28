using System;
using System.Collections.Generic;

namespace DMS.Entities
{
    public class Student
    {

        public Student()
        {
            RegisterRooms = new HashSet<RegisterRoom>();
            RegisterTags = new HashSet<RegisterTag>();
        }


        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string StudentCode { get; set; }
        public string StudentTel { get; set; }
        public string NationalCode { get; set; }
        public DateTime Birthday { get; set; }
        public string FatherName { get; set; }
        public string FatherTel { get; set; }
        public string HomeTel { get; set; }
        public string OtherName { get; set; }
        public string OtherTel { get; set; }
        public byte[] Img { get; set; }

        public int StudyID_FK { get; set; }
        public Study Study { get; set; }
        public int EducationalID_FK { get; set; }
        public EducationalCenter EducationalCenter { get; set; }


        public virtual ICollection<RegisterRoom> RegisterRooms { get; set; }
        public virtual ICollection<RegisterTag> RegisterTags { get; set; }

    }
}

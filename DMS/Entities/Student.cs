using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Student
    {

        public Student()
        {
            RegisterRooms = new HashSet<RegisterRoom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int StudentID { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "نام نام خانوادگی")]
        public string FullName { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "شماره دانشجویی")]
        public string StudentCode { get; set; }
        [Required]
        [MaxLength(11)]
        [Display(Name = "تلفن")]
        public string StudentTel { get; set; }
        [Required]
        [MaxLength(11)]
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }
        [Required]
        [Display(Name = "تولد")]
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "نام پدر")]
        public string FatherName { get; set; }
        [Required]
        [MaxLength(11)]
        [Display(Name = "تلفن پدر")]
        public string FatherTel { get; set; }
        [MaxLength(11)]
        [Display(Name = "تلفن منزل")]
        public string HomeTel { get; set; }
        [MaxLength(50)]
        [Display(Name = "بستگان")]
        public string OtherName { get; set; }
        [MaxLength(11)]
        [Display(Name = "تلفن بستگان")]
        public string OtherTel { get; set; }
        [Display(Name = "تصویر دانشجو")]
        public byte[] Img { get; set; }


        [Display(Name = "رشته تحصیلی")]
        public int StudyID_FK { get; set; }
        [ForeignKey("StudyID_FK")]
        public Study Study { get; set; }
        [Display(Name = "دانشگاه")]
        public int EducationalID_FK { get; set; }
        [ForeignKey("EducationalID_FK")]
        public EducationalCenter EducationalCenter { get; set; }


        public virtual ICollection<RegisterRoom> RegisterRooms { get; set; }

    }
}

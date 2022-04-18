using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class RegisterRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }

        //[Display(Name = "خوابگاه")]
        //public int DormitoryID_FK { get; set; }
        //[ForeignKey("DormitoryID_FK")]
        //public Dormitory Dormitory { get; set; }


        [Display(Name = "شماره اتاق")]
        public int RoomID_FK { get; set; }
        [ForeignKey("RoomID_FK")]
        public Room Room { get; set; }


        [Display(Name = "دانشجو")]
        public int StudentID_FK { get; set; }
        [ForeignKey("StudentID_FK")]
        public Student Student { get; set; }

        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }




    }
}

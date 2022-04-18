using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int RoomID { get; set; }
        [Required]
        [MaxLength(10)]
        [Display(Name = "شماره اتاق")]
        public string RoomNumber { get; set; }
        [Required]
        [Display(Name = "ظرفیت اتاق")]
        public int RoomCapacity { get; set; }
        [Required]
        [Display(Name = "امکانات رفاهی")]
        public string Facilities { get; set; }

        public int DormitoryID_FK { get; set; }
        [ForeignKey("DormitoryID_FK")]
        public Dormitory Dormitory { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Dormitory
    {

        public Dormitory()
        {
            Rooms = new HashSet<Room>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "نام خوابگاه")]
        public string DormitoryName { get; set; }
        [Required]
        [Display(Name = "تعداد اتاق")]
        public int Room { get; set; }
        [Required]
        [Display(Name = "ظرفیت کل")]
        public int Valence { get; set; }

      
        public virtual ICollection<Room> Rooms { get; set; }

    }
}

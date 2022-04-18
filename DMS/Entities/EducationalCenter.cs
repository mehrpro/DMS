using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class EducationalCenter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "نام دانشگاه")]
        public string EducationalName { get; set; }
        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Study
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "رشته تحصیلی")]
        public string StudyTitle { get; set; }
        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }

    }
}

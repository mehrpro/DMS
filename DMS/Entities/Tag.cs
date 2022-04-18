using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "تگ")]
        public string TadHEX { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "شماره سریال")]
        public string TagSerial { get; set; }
        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }
        [Display(AutoGenerateField = false)]
        public bool IsUsed { get; set; }
    }
}

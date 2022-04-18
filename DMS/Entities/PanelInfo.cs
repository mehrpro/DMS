using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class PanelInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "شماره پیامک")]
        public string SendNumber { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "گیرنده اخطار")]
        public string WarningReceiver { get; set; }
        [Display(Name = "حداقل توقف سامانه")]
        public int MinCredit { get; set; }
        [Display(Name = "حداقل ناحیه اخطار")]
        public int MidCredit { get; set; }
        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }
    }
}

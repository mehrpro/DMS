using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class ApplicationUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int UserID { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Required]
        [MaxLength(120)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Required] 
        [Display(Name = "سطح دسترسی")]
        public int Role { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "سمت")]
        public string Job { get; set; }
        [Required]
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
    }
}

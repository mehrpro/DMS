using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class Tagrecive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TagID { get; set; }
        public DateTime DateTimeRegister { get; set; }
        public bool sending { get; set; }
        [Required]
        [MaxLength(12)]
        public string Delivery { get; set; }

        public bool typeReg { get; set; }

        public int RegisterTagID_FK { get; set; }
        [ForeignKey("RegisterTagID_FK")]
        public RegisterTag RegisterTag { get; set; }

        public bool IsDeleted { get; set; }
    }
}

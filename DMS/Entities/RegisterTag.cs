using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Entities
{
    public class RegisterTag
    {

        public RegisterTag()
        {
            Tagrecives = new HashSet<Tagrecive>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شناسه")]
        public int ID { get; set; }


        public int StudentID_FK { get; set; }
        [ForeignKey("StudentID_FK")]
        public Student Student { get; set; }

        public int TagID_FK { get; set; }
        [ForeignKey("TagID_FK")]
        public Tag Tag { get; set; }

        [Display(AutoGenerateField = false)]
        public bool IsActive { get; set; }


        public virtual ICollection<Tagrecive> Tagrecives { get; set; }

    }
}

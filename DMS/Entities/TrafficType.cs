using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Entities
{
   public class TrafficType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)][Display(Name ="شناسه")]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)][Display(Name ="نوع تردد")]
        public string TrafficTypeTitle { get; set; }

    }
}

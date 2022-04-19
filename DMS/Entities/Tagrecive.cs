using System;

namespace DMS.Entities
{
    public class Tagrecive
    {
        public int ID { get; set; }
        public string TagID { get; set; }
        public DateTime DateTimeRegister { get; set; }
        public bool sending { get; set; }
        public string Delivery { get; set; }
        public bool? typeReg { get; set; }
        public int? RegisterTagID_FK { get; set; }
        public RegisterTag RegisterTag { get; set; }
        public bool IsDeleted { get; set; }
    }
}

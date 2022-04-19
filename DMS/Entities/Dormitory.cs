using System.Collections.Generic;

namespace DMS.Entities
{
    public class Dormitory
    {

        public Dormitory()
        {
            Rooms = new HashSet<Room>();
        }
        public int ID { get; set; }
        public string DormitoryName { get; set; }
        public int Room { get; set; }
        public int Valence { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }


    }
}

using System.Collections.Generic;

namespace DMS.Entities
{
    public class Room
    {

        public Room()
        {
            RegisterRooms = new HashSet<RegisterRoom>();
        }



        public int RoomID { get; set; }

        public string RoomNumber { get; set; }

        public int RoomCapacity { get; set; }

        public string Facilities { get; set; }
        public string IntFacilities { get; set; }
        public int DormitoryID_FK { get; set; }
        public Dormitory Dormitory { get; set; }



        public virtual ICollection<RegisterRoom> RegisterRooms { get; set; }

    }
}

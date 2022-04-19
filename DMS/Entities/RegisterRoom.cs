namespace DMS.Entities
{
    public class RegisterRoom
    {
        public int ID { get; set; }
        public int RoomID_FK { get; set; }
        public Room Room { get; set; }
        public int StudentID_FK { get; set; }
        public Student Student { get; set; }
        public bool IsActive { get; set; }
    }
}

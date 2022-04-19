namespace DMS.Entities
{
    public class Tag
    {
        public int ID { get; set; }
        public string TagID_HEX { get; set; }
        public string CartView { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUsed { get; set; }
    }
}

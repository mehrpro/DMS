namespace DMS.Entities
{
    public class Resource
    {
        public int UniqueID { get; set; }
        public int ResourceID { get; set; }
        public string? ResourceName { get; set; }
        public int? Color { get; set; }
        public byte[]? Image { get; set; }
        public string? CustomField1 { get; set; }

    }
}
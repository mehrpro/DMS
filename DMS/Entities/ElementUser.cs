namespace DMS.Entities
{
    public class ElementUser
    {
        public int ID { get; set; }
        public int UserID_FK { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int AccordionID_FK { get; set; }
        public AccordionElement AccordionElement { get; set; }
        public bool IsActive { get; set; }
        
    }
}
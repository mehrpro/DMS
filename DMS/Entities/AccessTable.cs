using System.Collections.Generic;

namespace DMS.Entities
{
    public class AccessTable
    {
        public AccessTable()
        {
            ApplicationUsers = new HashSet<ApplicationUser>();
        }

        public byte ID { get; set; }
        public string AccessTitle { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
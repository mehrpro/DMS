using System.Collections.Generic;

namespace DMS.Entities
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Tradods = new HashSet<Tradod>();
        }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Job { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Tradod> Tradods { get; set; }

    }
}

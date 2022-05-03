using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class ElementUserConfigure : EntityTypeConfiguration<ElementUser>
    {
        public ElementUserConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.AccordionID_FK).IsRequired();
            Property(x => x.UserID_FK).IsRequired();
        }
    }
}
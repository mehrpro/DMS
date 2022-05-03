using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DMS.Configuration
{
    using Entities;
    using System.Data.Entity;
    public class AccordionElementConfigure : EntityTypeConfiguration<AccordionElement>
    {
        public AccordionElementConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.AccTag).IsRequired().HasMaxLength(150);
            Property(x => x.EleTag).IsRequired().HasMaxLength(150);
            HasMany(x => x.ElementUsers)
                .WithRequired(x => x.AccordionElement)
                .HasForeignKey(x => x.AccordionID_FK).WillCascadeOnDelete(false);
        }
    }
}
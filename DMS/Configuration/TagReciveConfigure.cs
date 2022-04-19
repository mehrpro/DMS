using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class TagReciveConfigure : EntityTypeConfiguration<Tagrecive>
    {
        public TagReciveConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TagID).IsRequired().HasMaxLength(45);
            Property(x => x.DateTimeRegister).IsRequired().HasColumnType("datetime");
            Property(x => x.sending).IsRequired();
            Property(x => x.Delivery).HasMaxLength(10);
            Property(x => x.IsDeleted).IsRequired();

        }
    }
}
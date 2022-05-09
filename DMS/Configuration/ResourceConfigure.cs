using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class ResourceConfigure : EntityTypeConfiguration<Resource>
    {
        public ResourceConfigure()
        {
            HasKey(x => x.UniqueID);
            Property(x => x.UniqueID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ResourceID).IsRequired();
            Property(x => x.ResourceName).HasMaxLength(50);
            Property(x => x.CustomField1).IsMaxLength();
            Property(x => x.Image).HasColumnType("image");
        }
    }
}
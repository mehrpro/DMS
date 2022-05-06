using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class DestinationConfigure : EntityTypeConfiguration<Destination>
    {
        public DestinationConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DestinationTitle).IsRequired().HasMaxLength(100);
            HasMany(x=>x.Tradods)
                .WithRequired(x=>x.Destination)
                .HasForeignKey(x=>x.DestinationID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
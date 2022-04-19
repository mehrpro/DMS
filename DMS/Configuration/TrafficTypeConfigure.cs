using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class TrafficTypeConfigure : EntityTypeConfiguration<TrafficType>
    {
        public TrafficTypeConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TrafficTypeTitle).HasMaxLength(150).IsRequired();
        }
    }
}
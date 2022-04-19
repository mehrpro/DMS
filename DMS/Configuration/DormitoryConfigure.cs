using DMS.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DMS.Configuration
{
    public class DormitoryConfigure : EntityTypeConfiguration<Dormitory>
    {
        public DormitoryConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DormitoryName).IsRequired().HasMaxLength(50);
            Property(x => x.Room).IsRequired();
            Property(x => x.Valence).IsRequired();
            HasMany(x => x.Rooms)
                .WithRequired(x => x.Dormitory)
                .HasForeignKey(x => x.DormitoryID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}

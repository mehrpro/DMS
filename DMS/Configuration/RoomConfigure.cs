using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class RoomConfigure : EntityTypeConfiguration<Room>
    {
        public RoomConfigure()
        {
            HasKey(x => x.RoomID);
            Property(x => x.RoomID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Facilities).HasMaxLength(500);
            Property(x => x.RoomNumber).IsRequired().HasMaxLength(50);
            Property(x => x.RoomCapacity).IsRequired();
            HasMany(x => x.RegisterRooms)
                .WithRequired(x => x.Room)
                .HasForeignKey(x => x.RoomID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
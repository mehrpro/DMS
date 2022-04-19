using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class RegisterRoomConfigure : EntityTypeConfiguration<RegisterRoom>
    {
        public RegisterRoomConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.RoomID_FK).IsRequired();
            Property(x => x.StudentID_FK).IsRequired();
        }
    }
}
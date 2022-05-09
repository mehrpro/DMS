using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class AppointmentConfigure : EntityTypeConfiguration<Appointment>
    {
        public AppointmentConfigure()
        {
            HasKey(x => x.UniqueID);
            Property(x => x.UniqueID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StartDate).HasColumnType("smalldatetime");
            Property(x => x.EndDate).HasColumnType("smalldatetime");
            Property(x => x.Subject).HasMaxLength(50);
            Property(x => x.Location).HasMaxLength(50);
            Property(x => x.ResourceIDs).IsMaxLength();
            Property(x => x.ReminderInfo).IsMaxLength();
            Property(x => x.RecurrenceInfo).IsMaxLength();
            Property(x => x.TimeZoneId).IsMaxLength();
            Property(x => x.CustomField1).IsMaxLength();
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class TradodConfigure : EntityTypeConfiguration<Tradod>
    {
        public TradodConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.IsDelete).IsRequired();
            Property(x => x.StudentID_FK).IsRequired();
            Property(x => x.TrfficTypeID_FK).IsRequired();
            Property(x => x.UserID_FK).IsRequired();
            Property(x => x.SendSMS1).IsRequired();
            Property(x => x.SendSMS2).IsRequired();
            Property(x => x.Delivery1).HasMaxLength(20);
            Property(x => x.Delivery2).HasMaxLength(20);
            Property(x => x.ReciverNumber1).HasMaxLength(11);
            Property(x => x.ReciverNumber2).HasMaxLength(11);
        }

    }
}
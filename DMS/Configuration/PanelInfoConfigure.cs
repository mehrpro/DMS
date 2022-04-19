using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class PanelInfoConfigure : EntityTypeConfiguration<PanelInfo>
    {
        public PanelInfoConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SendNumber).IsRequired().HasMaxLength(25);
            Property(x => x.WarningReceiver).IsRequired().HasMaxLength(11);
            Property(x => x.Username).IsRequired().HasMaxLength(50);
            Property(x => x.Password).IsRequired().HasMaxLength(50);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.MinCredit).IsRequired();
            Property(x => x.MidCredit).IsRequired();

        }
    }
}
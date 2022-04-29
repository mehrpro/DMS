using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class CreditWarningConfigure: EntityTypeConfiguration<CreditWarning>
    {
        public CreditWarningConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Delivery).HasMaxLength(11);
            Property(x => x.ReciverWarning).HasMaxLength(11);
            Property(x => x.SendTime).HasColumnType("datetime");
            Property(x => x.IsDelete).IsRequired();
        }
    }
}
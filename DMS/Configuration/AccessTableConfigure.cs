using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class AccessTableConfigure : EntityTypeConfiguration<AccessTable>
    {
        public AccessTableConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccessTitle).IsRequired().HasMaxLength(20);
            HasMany(x => x.ApplicationUsers)
                .WithRequired(x => x.AccessTable)
                .HasForeignKey(x => x.AccessID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
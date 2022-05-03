using System.ComponentModel.DataAnnotations.Schema;
using DMS.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace DMS.Configuration
{
    public class ApplicationUserConfigure : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfigure()
        {
            HasKey(x => x.UserID);
            Property(x => x.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.Job).HasMaxLength(50);
            Property(x => x.Password).IsRequired().HasMaxLength(120);
            Property(x => x.Username).IsRequired().HasMaxLength(50);
            Property(x => x.AccessID_FK).IsRequired();
            HasMany(x => x.Tradods)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.ElementUsers)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK).WillCascadeOnDelete(false);


        }
    }
}
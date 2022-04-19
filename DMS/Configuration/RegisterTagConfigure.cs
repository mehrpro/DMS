using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class RegisterTagConfigure : EntityTypeConfiguration<RegisterTag>
    {
        public RegisterTagConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.TagID_FK).IsRequired();
            Property(x => x.StudentID_FK).IsRequired();
            HasMany(x => x.Tagrecives)
                .WithRequired(x => x.RegisterTag)
                .HasForeignKey(x => x.RegisterTagID_FK)
                .WillCascadeOnDelete(false);

        }
    }
}
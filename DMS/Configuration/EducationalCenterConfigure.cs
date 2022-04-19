using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class EducationalCenterConfigure : EntityTypeConfiguration<EducationalCenter>
    {
        public EducationalCenterConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.EducationalName).IsRequired().HasMaxLength(100);
            HasMany(x => x.Students)
                .WithRequired(x => x.EducationalCenter)
                .HasForeignKey(x => x.EducationalID_FK)
                .WillCascadeOnDelete(false);



        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class StudyConfigure : EntityTypeConfiguration<Study>
    {
        public StudyConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.StudyTitle).HasMaxLength(100).IsRequired();
            HasMany(x => x.Students)
                .WithRequired(x => x.Study)
                .HasForeignKey(x => x.StudyID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
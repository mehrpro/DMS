using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DevExpress.Printing.Native;
using DMS.Entities;

namespace DMS.Configuration
{
    public class StudentConfigure : EntityTypeConfiguration<Student>
    {
        public StudentConfigure()
        {
            HasKey(x => x.StudentID);
            Property(x => x.StudentID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FullName).IsRequired().HasMaxLength(150);
            Property(x => x.FatherName).IsRequired().HasMaxLength(100);
            Property(x => x.FatherTel).IsRequired().HasMaxLength(11);
            Property(x => x.HomeTel).HasMaxLength(11);
            Property(x => x.NationalCode).HasMaxLength(11).IsRequired();
            Property(x => x.Birthday).IsRequired().HasColumnType("datetime");
            Property(x => x.OtherName).HasMaxLength(150);
            Property(x => x.OtherTel).HasMaxLength(11);
            Property(x => x.StudentTel).HasMaxLength(11);
            Property(x => x.StudentCode).HasMaxLength(30);
            HasMany(x => x.RegisterRooms)
                .WithRequired(x => x.Student)
                .HasForeignKey(x => x.StudentID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x=>x.RegisterTags)
                .WithRequired(x=>x.Student)
                .HasForeignKey(x=>x.StudentID_FK)
                .WillCascadeOnDelete(false);

        }
    }
}
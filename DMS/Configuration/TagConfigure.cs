using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DMS.Entities;

namespace DMS.Configuration
{
    public class TagConfigure : EntityTypeConfiguration<Tag>
    {
        public TagConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.IsUsed).IsRequired();
            Property(x => x.IsDeleted).IsRequired();
            Property(x => x.TagID_HEX).IsRequired().HasMaxLength(50);
            Property(x => x.CartView).IsRequired().HasMaxLength(50);
            HasMany(x=>x.RegisterTags)
                .WithRequired(x=>x.Tag)
                .HasForeignKey(x=>x.TagID_FK)
                .WillCascadeOnDelete(false);

        }
    }
}
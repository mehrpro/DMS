using System.Data.Entity;

namespace DMS.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Conn")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Dormitory> Dormitories { get; set; }
        public virtual DbSet<EducationalCenter> EducationalCenters { get; set; }
        public virtual DbSet<PanelInfo> PanelInfos { get; set; }
        public virtual DbSet<RegisterTag> RegisterTags { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Study> Studies { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tagrecive> Tagrecives { get; set; }
        public virtual DbSet<TrafficType> TrafficTypes { get; set; }


    }
}

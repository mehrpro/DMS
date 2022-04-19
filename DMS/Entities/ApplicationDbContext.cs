using System.Data.Entity;
using DMS.Configuration;

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
            modelBuilder.Configurations.Add(new ApplicationUserConfigure());
            modelBuilder.Configurations.Add(new DormitoryConfigure());
            modelBuilder.Configurations.Add(new EducationalCenterConfigure());
            modelBuilder.Configurations.Add(new PanelInfoConfigure());
            modelBuilder.Configurations.Add(new RegisterRoomConfigure());
            modelBuilder.Configurations.Add(new RegisterTagConfigure());
            modelBuilder.Configurations.Add(new RoomConfigure());
            modelBuilder.Configurations.Add(new StudentConfigure());
            modelBuilder.Configurations.Add(new StudyConfigure());
            modelBuilder.Configurations.Add(new TagConfigure());
            modelBuilder.Configurations.Add(new TagReciveConfigure());
            modelBuilder.Configurations.Add(new TrafficTypeConfigure());
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
        public virtual DbSet<RegisterRoom> RegisterRooms { get; set; }


    }
}

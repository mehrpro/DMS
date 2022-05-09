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
            modelBuilder.Configurations.Add(new TradodConfigure());
            modelBuilder.Configurations.Add(new DestinationConfigure());
            modelBuilder.Configurations.Add(new CreditWarningConfigure());
            modelBuilder.Configurations.Add(new ElementUserConfigure());
            modelBuilder.Configurations.Add(new AccordionElementConfigure());
            modelBuilder.Configurations.Add(new AccessTableConfigure());
            modelBuilder.Configurations.Add(new AppointmentConfigure());
            modelBuilder.Configurations.Add(new ResourceConfigure());
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
        public virtual DbSet<Tradod> Tradods { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<CreditWarning> CreditWarnings { get; set; }
        public virtual DbSet<AccordionElement> AccordionElements { get; set; }
        public virtual DbSet<ElementUser> ElementUsers { get; set; }
        public virtual DbSet<AccessTable> AccessTables { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }


    }
}

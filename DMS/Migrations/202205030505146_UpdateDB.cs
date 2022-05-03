namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessTables",
                c => new
                {
                    ID = c.Byte(nullable: false, identity: true),
                    AccessTitle = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                {
                    UserID = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false, maxLength: 50),
                    Password = c.String(nullable: false, maxLength: 120),
                    AccessID_FK = c.Byte(nullable: false),
                    Job = c.String(maxLength: 50),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.AccessTables", t => t.AccessID_FK)
                .Index(t => t.AccessID_FK);

            CreateTable(
                "dbo.ElementUsers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    UserID_FK = c.Int(nullable: false),
                    AccordionID_FK = c.Int(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AccordionElements", t => t.AccordionID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .Index(t => t.UserID_FK)
                .Index(t => t.AccordionID_FK);

            CreateTable(
                "dbo.AccordionElements",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    AccTag = c.String(nullable: false, maxLength: 150),
                    EleTag = c.String(nullable: false, maxLength: 150),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Tradods",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    StudentID_FK = c.Int(nullable: false),
                    TrfficTypeID_FK = c.Int(nullable: false),
                    OutTime = c.DateTime(nullable: false),
                    InCommingTime = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    IsDelete = c.Boolean(nullable: false),
                    UserID_FK = c.Int(nullable: false),
                    SendSMS1 = c.Boolean(nullable: false),
                    ReciverNumber1 = c.String(maxLength: 11),
                    Delivery1 = c.String(maxLength: 20),
                    SendSMS2 = c.String(nullable: false),
                    ReciverNumber2 = c.String(maxLength: 11),
                    Delivery2 = c.String(maxLength: 20),
                    Student_StudentID = c.Int(),
                    Destination_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .ForeignKey("dbo.TrafficTypes", t => t.TrfficTypeID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .ForeignKey("dbo.Destinations", t => t.Destination_ID)
                .Index(t => t.TrfficTypeID_FK)
                .Index(t => t.UserID_FK)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Destination_ID);

            CreateTable(
                "dbo.Students",
                c => new
                {
                    StudentID = c.Int(nullable: false, identity: true),
                    FullName = c.String(nullable: false, maxLength: 150),
                    StudentCode = c.String(maxLength: 30),
                    StudentTel = c.String(maxLength: 11),
                    NationalCode = c.String(nullable: false, maxLength: 11),
                    Birthday = c.DateTime(nullable: false),
                    FatherName = c.String(nullable: false, maxLength: 100),
                    FatherTel = c.String(nullable: false, maxLength: 11),
                    HomeTel = c.String(maxLength: 11),
                    OtherName = c.String(maxLength: 150),
                    OtherTel = c.String(maxLength: 11),
                    Img = c.Binary(),
                    StudyID_FK = c.Int(nullable: false),
                    EducationalID_FK = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.EducationalCenters", t => t.EducationalID_FK)
                .ForeignKey("dbo.Studies", t => t.StudyID_FK)
                .Index(t => t.StudyID_FK)
                .Index(t => t.EducationalID_FK);

            CreateTable(
                "dbo.EducationalCenters",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    EducationalName = c.String(nullable: false, maxLength: 100),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.RegisterRooms",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    RoomID_FK = c.Int(nullable: false),
                    StudentID_FK = c.Int(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.RoomID_FK)
                .ForeignKey("dbo.Students", t => t.StudentID_FK)
                .Index(t => t.RoomID_FK)
                .Index(t => t.StudentID_FK);

            CreateTable(
                "dbo.Rooms",
                c => new
                {
                    RoomID = c.Int(nullable: false, identity: true),
                    RoomNumber = c.String(nullable: false, maxLength: 50),
                    RoomCapacity = c.Int(nullable: false),
                    Facilities = c.String(maxLength: 500),
                    IntFacilities = c.String(maxLength: 100),
                    DormitoryID_FK = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Dormitories", t => t.DormitoryID_FK)
                .Index(t => t.DormitoryID_FK);

            CreateTable(
                "dbo.Dormitories",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    DormitoryName = c.String(nullable: false, maxLength: 50),
                    Room = c.Int(nullable: false),
                    Valence = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.RegisterTags",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    StudentID_FK = c.Int(nullable: false),
                    TagID_FK = c.Int(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tags", t => t.TagID_FK)
                .ForeignKey("dbo.Students", t => t.StudentID_FK)
                .Index(t => t.StudentID_FK)
                .Index(t => t.TagID_FK);

            CreateTable(
                "dbo.Tags",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TagID_HEX = c.String(nullable: false, maxLength: 50),
                    CartView = c.String(nullable: false, maxLength: 50),
                    IsDeleted = c.Boolean(nullable: false),
                    IsUsed = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Tagrecives",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TagID = c.String(nullable: false, maxLength: 45),
                    DateTimeRegister = c.DateTime(nullable: false),
                    sending = c.Boolean(nullable: false),
                    Delivery = c.String(maxLength: 10),
                    typeReg = c.Boolean(),
                    RegisterTagID_FK = c.Int(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RegisterTags", t => t.RegisterTagID_FK)
                .Index(t => t.RegisterTagID_FK);

            CreateTable(
                "dbo.Studies",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    StudyTitle = c.String(nullable: false, maxLength: 100),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.TrafficTypes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TrafficTypeTitle = c.String(nullable: false, maxLength: 150),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.CreditWarnings",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ReciverWarning = c.String(maxLength: 11),
                    SendTime = c.DateTime(nullable: false),
                    Delivery = c.String(maxLength: 11),
                    CreditLevel = c.Int(nullable: false),
                    IsDelete = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Destinations",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    DestinationTitle = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.PanelInfoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SendNumber = c.String(nullable: false, maxLength: 25),
                    WarningReceiver = c.String(nullable: false, maxLength: 11),
                    MinCredit = c.Int(nullable: false),
                    MidCredit = c.Int(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    Username = c.String(nullable: false, maxLength: 50),
                    Password = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Tradods", "Destination_ID", "dbo.Destinations");
            DropForeignKey("dbo.ApplicationUsers", "AccessID_FK", "dbo.AccessTables");
            DropForeignKey("dbo.Tradods", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Tradods", "TrfficTypeID_FK", "dbo.TrafficTypes");
            DropForeignKey("dbo.Tradods", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "StudyID_FK", "dbo.Studies");
            DropForeignKey("dbo.RegisterTags", "StudentID_FK", "dbo.Students");
            DropForeignKey("dbo.Tagrecives", "RegisterTagID_FK", "dbo.RegisterTags");
            DropForeignKey("dbo.RegisterTags", "TagID_FK", "dbo.Tags");
            DropForeignKey("dbo.RegisterRooms", "StudentID_FK", "dbo.Students");
            DropForeignKey("dbo.RegisterRooms", "RoomID_FK", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "DormitoryID_FK", "dbo.Dormitories");
            DropForeignKey("dbo.Students", "EducationalID_FK", "dbo.EducationalCenters");
            DropForeignKey("dbo.ElementUsers", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ElementUsers", "AccordionID_FK", "dbo.AccordionElements");
            DropIndex("dbo.Tagrecives", new[] { "RegisterTagID_FK" });
            DropIndex("dbo.RegisterTags", new[] { "TagID_FK" });
            DropIndex("dbo.RegisterTags", new[] { "StudentID_FK" });
            DropIndex("dbo.Rooms", new[] { "DormitoryID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "StudentID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "RoomID_FK" });
            DropIndex("dbo.Students", new[] { "EducationalID_FK" });
            DropIndex("dbo.Students", new[] { "StudyID_FK" });
            DropIndex("dbo.Tradods", new[] { "Destination_ID" });
            DropIndex("dbo.Tradods", new[] { "Student_StudentID" });
            DropIndex("dbo.Tradods", new[] { "UserID_FK" });
            DropIndex("dbo.Tradods", new[] { "TrfficTypeID_FK" });
            DropIndex("dbo.ElementUsers", new[] { "AccordionID_FK" });
            DropIndex("dbo.ElementUsers", new[] { "UserID_FK" });
            DropIndex("dbo.ApplicationUsers", new[] { "AccessID_FK" });
            DropTable("dbo.PanelInfoes");
            DropTable("dbo.Destinations");
            DropTable("dbo.CreditWarnings");
            DropTable("dbo.TrafficTypes");
            DropTable("dbo.Studies");
            DropTable("dbo.Tagrecives");
            DropTable("dbo.Tags");
            DropTable("dbo.RegisterTags");
            DropTable("dbo.Dormitories");
            DropTable("dbo.Rooms");
            DropTable("dbo.RegisterRooms");
            DropTable("dbo.EducationalCenters");
            DropTable("dbo.Students");
            DropTable("dbo.Tradods");
            DropTable("dbo.AccordionElements");
            DropTable("dbo.ElementUsers");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.AccessTables");
        }
    }
}

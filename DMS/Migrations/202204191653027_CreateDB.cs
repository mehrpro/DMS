namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 120),
                        Role = c.Int(nullable: false),
                        Job = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
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
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(nullable: false, maxLength: 50),
                        RoomCapacity = c.Int(nullable: false),
                        Facilities = c.String(maxLength: 500),
                        DormitoryID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Dormitories", t => t.DormitoryID_FK)
                .Index(t => t.DormitoryID_FK);
            
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
                .ForeignKey("dbo.Students", t => t.StudentID_FK)
                .ForeignKey("dbo.Rooms", t => t.RoomID_FK)
                .Index(t => t.RoomID_FK)
                .Index(t => t.StudentID_FK);
            
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
                "dbo.Studies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudyTitle = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
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
            
            CreateTable(
                "dbo.RegisterTags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID_FK = c.Int(nullable: false),
                        TagID_FK = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Student_StudentID = c.Int(),
                        Tag_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .ForeignKey("dbo.Tags", t => t.Tag_ID)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Tag_ID);
            
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
                "dbo.TrafficTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TrafficTypeTitle = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tagrecives", "RegisterTagID_FK", "dbo.RegisterTags");
            DropForeignKey("dbo.RegisterTags", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.RegisterTags", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Rooms", "DormitoryID_FK", "dbo.Dormitories");
            DropForeignKey("dbo.RegisterRooms", "RoomID_FK", "dbo.Rooms");
            DropForeignKey("dbo.Students", "StudyID_FK", "dbo.Studies");
            DropForeignKey("dbo.RegisterRooms", "StudentID_FK", "dbo.Students");
            DropForeignKey("dbo.Students", "EducationalID_FK", "dbo.EducationalCenters");
            DropIndex("dbo.Tagrecives", new[] { "RegisterTagID_FK" });
            DropIndex("dbo.RegisterTags", new[] { "Tag_ID" });
            DropIndex("dbo.RegisterTags", new[] { "Student_StudentID" });
            DropIndex("dbo.Students", new[] { "EducationalID_FK" });
            DropIndex("dbo.Students", new[] { "StudyID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "StudentID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "RoomID_FK" });
            DropIndex("dbo.Rooms", new[] { "DormitoryID_FK" });
            DropTable("dbo.TrafficTypes");
            DropTable("dbo.Tagrecives");
            DropTable("dbo.Tags");
            DropTable("dbo.RegisterTags");
            DropTable("dbo.PanelInfoes");
            DropTable("dbo.Studies");
            DropTable("dbo.EducationalCenters");
            DropTable("dbo.Students");
            DropTable("dbo.RegisterRooms");
            DropTable("dbo.Rooms");
            DropTable("dbo.Dormitories");
            DropTable("dbo.ApplicationUsers");
        }
    }
}

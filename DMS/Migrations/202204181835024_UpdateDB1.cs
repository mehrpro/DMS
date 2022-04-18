namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterRooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DormitoryID_FK = c.Int(nullable: false),
                        RoomID_FK = c.Int(nullable: false),
                        StudentID_FK = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dormitories", t => t.DormitoryID_FK, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID_FK, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID_FK, cascadeDelete: true)
                .Index(t => t.DormitoryID_FK)
                .Index(t => t.RoomID_FK)
                .Index(t => t.StudentID_FK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisterRooms", "StudentID_FK", "dbo.Students");
            DropForeignKey("dbo.RegisterRooms", "RoomID_FK", "dbo.Rooms");
            DropForeignKey("dbo.RegisterRooms", "DormitoryID_FK", "dbo.Dormitories");
            DropIndex("dbo.RegisterRooms", new[] { "StudentID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "RoomID_FK" });
            DropIndex("dbo.RegisterRooms", new[] { "DormitoryID_FK" });
            DropTable("dbo.RegisterRooms");
        }
    }
}

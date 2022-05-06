namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tradods", new[] { "Student_StudentID" });
            DropIndex("dbo.Tradods", new[] { "Destination_ID" });
            DropColumn("dbo.Tradods", "StudentID_FK");
            RenameColumn(table: "dbo.Tradods", name: "Student_StudentID", newName: "StudentID_FK");
            RenameColumn(table: "dbo.Tradods", name: "Destination_ID", newName: "DestinationID_FK");
            AlterColumn("dbo.Tradods", "StudentID_FK", c => c.Int(nullable: false));
            AlterColumn("dbo.Tradods", "DestinationID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.Tradods", "StudentID_FK");
            CreateIndex("dbo.Tradods", "DestinationID_FK");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tradods", new[] { "DestinationID_FK" });
            DropIndex("dbo.Tradods", new[] { "StudentID_FK" });
            AlterColumn("dbo.Tradods", "DestinationID_FK", c => c.Int());
            AlterColumn("dbo.Tradods", "StudentID_FK", c => c.Int());
            RenameColumn(table: "dbo.Tradods", name: "DestinationID_FK", newName: "Destination_ID");
            RenameColumn(table: "dbo.Tradods", name: "StudentID_FK", newName: "Student_StudentID");
            AddColumn("dbo.Tradods", "StudentID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.Tradods", "Destination_ID");
            CreateIndex("dbo.Tradods", "Student_StudentID");
        }
    }
}

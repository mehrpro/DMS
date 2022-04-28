namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pdateDB : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.RegisterTags", new[] { "Student_StudentID" });
            DropIndex("dbo.RegisterTags", new[] { "Tag_ID" });
            DropColumn("dbo.RegisterTags", "StudentID_FK");
            DropColumn("dbo.RegisterTags", "TagID_FK");
            RenameColumn(table: "dbo.RegisterTags", name: "Student_StudentID", newName: "StudentID_FK");
            RenameColumn(table: "dbo.RegisterTags", name: "Tag_ID", newName: "TagID_FK");
            AlterColumn("dbo.RegisterTags", "StudentID_FK", c => c.Int(nullable: false));
            AlterColumn("dbo.RegisterTags", "TagID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.RegisterTags", "StudentID_FK");
            CreateIndex("dbo.RegisterTags", "TagID_FK");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RegisterTags", new[] { "TagID_FK" });
            DropIndex("dbo.RegisterTags", new[] { "StudentID_FK" });
            AlterColumn("dbo.RegisterTags", "TagID_FK", c => c.Int());
            AlterColumn("dbo.RegisterTags", "StudentID_FK", c => c.Int());
            RenameColumn(table: "dbo.RegisterTags", name: "TagID_FK", newName: "Tag_ID");
            RenameColumn(table: "dbo.RegisterTags", name: "StudentID_FK", newName: "Student_StudentID");
            AddColumn("dbo.RegisterTags", "TagID_FK", c => c.Int(nullable: false));
            AddColumn("dbo.RegisterTags", "StudentID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.RegisterTags", "Tag_ID");
            CreateIndex("dbo.RegisterTags", "Student_StudentID");
        }
    }
}

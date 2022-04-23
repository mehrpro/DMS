namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Img", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Img");
        }
    }
}

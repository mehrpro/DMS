namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "IntFacilities", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "IntFacilities");
        }
    }
}

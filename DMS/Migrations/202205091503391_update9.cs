namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resources", "Image", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resources", "Image", c => c.Binary());
        }
    }
}

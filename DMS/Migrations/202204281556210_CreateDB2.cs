namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DestinationTitle = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Tradods", "Destination_ID", c => c.Int());
            CreateIndex("dbo.Tradods", "Destination_ID");
            AddForeignKey("dbo.Tradods", "Destination_ID", "dbo.Destinations", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tradods", "Destination_ID", "dbo.Destinations");
            DropIndex("dbo.Tradods", new[] { "Destination_ID" });
            DropColumn("dbo.Tradods", "Destination_ID");
            DropTable("dbo.Destinations");
        }
    }
}

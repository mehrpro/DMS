namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditWarnings");
        }
    }
}

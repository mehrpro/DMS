namespace DMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        Type = c.Int(),
                        StartDate = c.DateTime(storeType: "smalldatetime"),
                        EndDate = c.DateTime(storeType: "smalldatetime"),
                        AllDay = c.Boolean(),
                        Subject = c.String(maxLength: 50),
                        Location = c.String(maxLength: 50),
                        Description = c.String(),
                        Status = c.Int(),
                        Label = c.Int(),
                        ResourceID = c.Int(),
                        ResourceIDs = c.String(),
                        ReminderInfo = c.String(),
                        RecurrenceInfo = c.String(),
                        TimeZoneId = c.String(),
                        CustomField1 = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        ResourceID = c.Int(nullable: false),
                        ResourceName = c.String(maxLength: 50),
                        Color = c.Int(),
                        Image = c.Binary(),
                        CustomField1 = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resources");
            DropTable("dbo.Appointments");
        }
    }
}

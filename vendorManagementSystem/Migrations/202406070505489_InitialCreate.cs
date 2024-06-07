namespace vendorManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDescription = c.String(),
                        EventType = c.String(),
                        EventLocation = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.UserEvents",
                c => new
                    {
                        UserEventId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                        Status = c.String(),
                        Notes = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserEventId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEvents", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserEvents", "EventId", "dbo.Events");
            DropIndex("dbo.UserEvents", new[] { "EventId" });
            DropIndex("dbo.UserEvents", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserEvents");
            DropTable("dbo.Events");
        }
    }
}

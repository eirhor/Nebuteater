namespace Nebuteater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Performance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayId = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        MaxAmountOfTickets = c.Int(nullable: false),
                        FewTicketsLeft = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Play", t => t.PlayId, cascadeDelete: true)
                .Index(t => t.PlayId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PerformanceId = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        AmountOfTickets = c.Int(nullable: false),
                        HasWheelchar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Performance", t => t.PerformanceId, cascadeDelete: true)
                .Index(t => t.PerformanceId);
            
            CreateTable(
                "dbo.Play",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Location = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        PaymentMethod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        GroupAName = c.String(),
                        GroupBName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Play", t => t.PlayId, cascadeDelete: true)
                .Index(t => t.PlayId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Role", "PlayId", "dbo.Play");
            DropForeignKey("dbo.Performance", "PlayId", "dbo.Play");
            DropForeignKey("dbo.Reservations", "PerformanceId", "dbo.Performance");
            DropIndex("dbo.Role", new[] { "PlayId" });
            DropIndex("dbo.Reservations", new[] { "PerformanceId" });
            DropIndex("dbo.Performance", new[] { "PlayId" });
            DropTable("dbo.User");
            DropTable("dbo.Role");
            DropTable("dbo.Play");
            DropTable("dbo.Reservations");
            DropTable("dbo.Performance");
        }
    }
}

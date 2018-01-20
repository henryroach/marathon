namespace Marathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomePlayerOneId = c.Int(nullable: false),
                        HomePlayerTwoId = c.Int(nullable: false),
                        GuestPlayerOneId = c.Int(nullable: false),
                        GuestPlayerTwoId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.GuestPlayerOneId)
                .ForeignKey("dbo.Players", t => t.GuestPlayerTwoId)
                .ForeignKey("dbo.Players", t => t.HomePlayerOneId)
                .ForeignKey("dbo.Players", t => t.HomePlayerTwoId)
                .Index(t => t.HomePlayerOneId)
                .Index(t => t.HomePlayerTwoId)
                .Index(t => t.GuestPlayerOneId)
                .Index(t => t.GuestPlayerTwoId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsHome = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarathonStart = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Points", "HomePlayerTwoId", "dbo.Players");
            DropForeignKey("dbo.Points", "HomePlayerOneId", "dbo.Players");
            DropForeignKey("dbo.Points", "GuestPlayerTwoId", "dbo.Players");
            DropForeignKey("dbo.Points", "GuestPlayerOneId", "dbo.Players");
            DropIndex("dbo.Points", new[] { "GuestPlayerTwoId" });
            DropIndex("dbo.Points", new[] { "GuestPlayerOneId" });
            DropIndex("dbo.Points", new[] { "HomePlayerTwoId" });
            DropIndex("dbo.Points", new[] { "HomePlayerOneId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.Settings");
            DropTable("dbo.Teams");
            DropTable("dbo.Points");
            DropTable("dbo.Players");
        }
    }
}

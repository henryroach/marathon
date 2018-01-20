namespace Marathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGainTeamToPoint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Points", "GainTeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.Points", "GainTeamId");
            AddForeignKey("dbo.Points", "GainTeamId", "dbo.Teams", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Points", "GainTeamId", "dbo.Teams");
            DropIndex("dbo.Points", new[] { "GainTeamId" });
            DropColumn("dbo.Points", "GainTeamId");
        }
    }
}

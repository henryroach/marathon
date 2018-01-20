namespace Marathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMatchIdToPoint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Points", "MatchId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Points", "MatchId");
        }
    }
}

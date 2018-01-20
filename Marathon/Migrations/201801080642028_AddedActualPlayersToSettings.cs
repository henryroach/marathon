namespace Marathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedActualPlayersToSettings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "ActualHomePlayerOne", c => c.Int());
            AddColumn("dbo.Settings", "ActualHomePlayerTwo", c => c.Int());
            AddColumn("dbo.Settings", "ActualGuestPlayerOne", c => c.Int());
            AddColumn("dbo.Settings", "ActualGuestPlayerTwo", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "ActualGuestPlayerTwo");
            DropColumn("dbo.Settings", "ActualGuestPlayerOne");
            DropColumn("dbo.Settings", "ActualHomePlayerTwo");
            DropColumn("dbo.Settings", "ActualHomePlayerOne");
        }
    }
}

namespace Marathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatisticalViews : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE VIEW dbo.MarathonStatistics
            AS
            SELECT
                p.Id,
                hp1.Name[Home player 1],
                hp2.Name[Home player 2],
                gp1.Name[Guest player 1],
                gp2.Name[Guest player 2],
                FORMAT(Created, 'dd.MM.yyyy HH:mm:ss') Created,
                t.Name GainTeamName,
                p.MatchId
            FROM dbo.Points p
            JOIN dbo.Players hp1 ON hp1.Id = p.HomePlayerOneId
            JOIN dbo.Players hp2 ON hp2.Id = p.HomePlayerTwoId
            JOIN dbo.Players gp1 ON gp1.Id = p.GuestPlayerOneId
            JOIN dbo.Players gp2 ON gp2.Id = p.GuestPlayerTwoId
            JOIN dbo.Teams t ON t.Id = p.GainTeamId");

            Sql(@"CREATE VIEW dbo.MarathonPlayers
            AS
                SELECT

            t.Name TeamName,
                p.Name PlayerName
            FROM dbo.Players p
            JOIN dbo.Teams t ON t.Id = p.TeamId");
        }
        
        public override void Down()
        {
            Sql("DROP VIEW dbo.MarathonStatistics");
            Sql("DROP VIEW dbo.MarathonPlayers");
        }
    }
}

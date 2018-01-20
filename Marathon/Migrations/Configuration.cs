using System.Data.Entity.Migrations;
using Marathon.Entities;

namespace Marathon.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Marathon.MarathonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarathonContext context)
        {
            context.Teams.AddOrUpdate(x => x.Name, new Team { Name = "Jílové u Prahy", IsHome = true});
            context.Teams.AddOrUpdate(x => x.Name, new Team { Name = "Zruè nad Sázavou" });
    }
}
}

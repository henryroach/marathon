using System.Data.Entity;
using Marathon.Entities;

namespace Marathon
{
    public class MarathonContext : DbContext
    {
        public MarathonContext()
            : base("name=MarathonContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Point>()
                .HasRequired(m => m.HomePlayerOne)
                .WithMany(t => t.HomePlayerOnePoints)
                .HasForeignKey(m => m.HomePlayerOneId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Point>()
                .HasRequired(m => m.HomePlayerTwo)
                .WithMany(t => t.HomePlayerTwoPoints)
                .HasForeignKey(m => m.HomePlayerTwoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Point>()
                .HasRequired(m => m.GuestPlayerOne)
                .WithMany(t => t.GuestPlayerOnePoints)
                .HasForeignKey(m => m.GuestPlayerOneId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Point>()
                .HasRequired(m => m.GuestPlayerTwo)
                .WithMany(t => t.GuestPlayerTwoPoints)
                .HasForeignKey(m => m.GuestPlayerTwoId)
                .WillCascadeOnDelete(false);
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
using System.Data.Entity;
using Nebuteater.Data.Configuration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Contexts
{
    public class TheatreDbContext : DbContext
    {
        public TheatreDbContext() : base("TheatreDb")
        {
            
        }
        
        public DbSet<Play> Plays { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public virtual void Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlayConfiguration());
            modelBuilder.Configurations.Add(new PerformanceConfiguration());
            modelBuilder.Configurations.Add(new ReservationConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
        }
    }
}
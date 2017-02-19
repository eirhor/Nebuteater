using System.Data.Entity.ModelConfiguration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Configuration
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            ToTable("Reservations");
            Property(c => c.FullName).IsRequired();
            Property(c => c.Email).IsRequired();
            Property(c => c.AmountOfTickets).IsRequired();
        }
    }
}
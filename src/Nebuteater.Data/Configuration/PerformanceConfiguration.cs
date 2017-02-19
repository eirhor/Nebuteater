using System.Data.Entity.ModelConfiguration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Configuration
{
    public class PerformanceConfiguration : EntityTypeConfiguration<Performance>
    {
        public PerformanceConfiguration()
        {
            ToTable("Performance");
            Property(c => c.MaxAmountOfTickets).IsRequired();
            Property(c => c.StartDateTime).IsRequired();
        }
    }
}
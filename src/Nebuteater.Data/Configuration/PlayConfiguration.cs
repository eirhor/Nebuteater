using System.Data.Entity.ModelConfiguration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Configuration
{
    public class PlayConfiguration : EntityTypeConfiguration<Play>
    {
        public PlayConfiguration()
        {
            ToTable("Play");
            Property(c => c.Name).IsRequired();
            Property(c => c.Location).IsRequired();
            Property(c => c.Price).IsRequired();
        }
    }
}
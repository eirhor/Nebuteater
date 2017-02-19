using System.Data.Entity.ModelConfiguration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Role");
            Property(c => c.Name).IsRequired();
        }
    }
}
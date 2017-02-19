using System.Data.Entity.ModelConfiguration;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            Property(c => c.FullName).IsRequired();
            Property(c => c.Email).IsRequired();
            Property(c => c.Password).IsRequired();
        }
    }
}
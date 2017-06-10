using Microsoft.AspNet.Identity.EntityFramework;
using Nebuteater.Identity.Infrastructure;
using Nebuteater.Identity.Models;

namespace Nebuteater.Identity.Contexts
{
    public class TheatreIdentityDbContext : IdentityDbContext<TheatreIdentityUser>
    {
        public TheatreIdentityDbContext() : base("TheatreDb", throwIfV1Schema: false) { }

        static TheatreIdentityDbContext()
        {
            System.Data.Entity.Database.SetInitializer<TheatreIdentityDbContext>(new TheatreIdentityDbInitializer());
        }

        public static TheatreIdentityDbContext Create()
        {
            return new TheatreIdentityDbContext();
        }
    }
}
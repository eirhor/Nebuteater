using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Nebuteater.Identity.Contexts;

namespace Nebuteater.Identity.Infrastructure
{
    public class TheatreIdentityRoleManager : RoleManager<IdentityRole>
    {
        public TheatreIdentityRoleManager(IRoleStore<IdentityRole, string> roleStore) : base(roleStore) { }

        public static TheatreIdentityRoleManager Create(IdentityFactoryOptions<TheatreIdentityRoleManager> options,
            IOwinContext context)
        {
            return new TheatreIdentityRoleManager(new RoleStore<IdentityRole>(context.Get<TheatreIdentityDbContext>()));
        }
    }
}
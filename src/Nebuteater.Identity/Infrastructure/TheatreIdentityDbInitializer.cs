using System.Configuration;
using System.Data.Entity;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Nebuteater.Identity.Contexts;
using Nebuteater.Identity.Models;

namespace Nebuteater.Identity.Infrastructure
{
    public class TheatreIdentityDbInitializer : DropCreateDatabaseIfModelChanges<TheatreIdentityDbContext>
    {
        protected override void Seed(TheatreIdentityDbContext context)
        {
            InitializeDefaultAdminUser(context);
            base.Seed(context);
        }

        public static IdentityRole CreateAdminRole(TheatreIdentityRoleManager roleManager)
        {
            var roleName = ConfigurationManager.AppSettings["AdminRoleName"];

            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new IdentityRole(roleName);
                roleManager.Create(role);
            }

            return role;
        }

        public static TheatreIdentityUser CreateAdminUser(TheatreIdentityUserManager userManager, string username, string password)
        {
            var user = userManager.FindByName(username);
            if (user == null)
            {
                user = new TheatreIdentityUser { UserName = username, Email = username };
                userManager.Create(user, password);
                userManager.SetLockoutEnabled(user.Id, false);
            }

            return user;
        }

        public static void AssignAdminRoleToUser(TheatreIdentityUserManager userManager, TheatreIdentityUser user, IdentityRole role)
        {
            var userRoles = userManager.GetRoles(user.Id);
            if (!userRoles.Contains(role.Name))
                userManager.AddToRole(user.Id, role.Name);
        }

        public static void InitializeDefaultAdminUser(TheatreIdentityDbContext dbContext)
        {
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<TheatreIdentityUserManager>();
            var roleManager = HttpContext.Current.GetOwinContext().Get<TheatreIdentityRoleManager>();
            var username = ConfigurationManager.AppSettings["AdminEmail"];
            var password = ConfigurationManager.AppSettings["AdminPassword"];

            var role = CreateAdminRole(roleManager);
            var user = CreateAdminUser(userManager, username, password);

            AssignAdminRoleToUser(userManager, user, role);
        }
    }
}
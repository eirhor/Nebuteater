using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Nebuteater.Identity.Models;

namespace Nebuteater.Identity.Infrastructure
{
    public class TheatreIdentitySignInManager : SignInManager<TheatreIdentityUser, string>
    {
        public TheatreIdentitySignInManager(TheatreIdentityUserManager userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager) { }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(TheatreIdentityUser user)
        {
            return user.GenerateUserIdentityAsync(UserManager as TheatreIdentityUserManager);
        }

        public static TheatreIdentitySignInManager Create(IdentityFactoryOptions<TheatreIdentitySignInManager> options, IOwinContext context)
        {
            return new TheatreIdentitySignInManager(context.GetUserManager<TheatreIdentityUserManager>(), context.Authentication);
        }
    }
}
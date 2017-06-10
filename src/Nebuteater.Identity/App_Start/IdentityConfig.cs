using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Nebuteater.Core;
using Nebuteater.Identity.Contexts;
using Nebuteater.Identity.Infrastructure;
using Nebuteater.Identity.Models;
using Owin;

namespace Nebuteater.Identity
{
    public static class IdentityConfig
    {
        public static void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(TheatreIdentityDbContext.Create);
            app.CreatePerOwinContext<TheatreIdentityUserManager>(TheatreIdentityUserManager.Create);
            app.CreatePerOwinContext<TheatreIdentityRoleManager>(TheatreIdentityRoleManager.Create);
            app.CreatePerOwinContext<TheatreIdentitySignInManager>(TheatreIdentitySignInManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString(PathNames.Identity.Login),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<TheatreIdentityUserManager, TheatreIdentityUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);
        }
    }
}
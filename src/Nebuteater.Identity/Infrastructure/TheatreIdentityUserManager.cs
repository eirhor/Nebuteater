using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Nebuteater.Identity.Contexts;
using Nebuteater.Identity.Models;
using Nebuteater.Identity.Services;

namespace Nebuteater.Identity.Infrastructure
{
    public class TheatreIdentityUserManager : UserManager<TheatreIdentityUser>
    {
        public TheatreIdentityUserManager(IUserStore<TheatreIdentityUser> store) : base(store) { }

        public static TheatreIdentityUserManager Create(IdentityFactoryOptions<TheatreIdentityUserManager> options, IOwinContext context)
        {
            var manager = new TheatreIdentityUserManager(new UserStore<TheatreIdentityUser>(context.Get<TheatreIdentityDbContext>()));
            manager.UserValidator = new UserValidator<TheatreIdentityUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true
            };

            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            manager.RegisterTwoFactorProvider("EmailCode", new EmailTokenProvider<TheatreIdentityUser>
            {
                Subject = "Nebuteater sikkerhetskode",
                BodyFormat = "Din sikkerhetskode er {0}"
            });
            manager.EmailService = new IdentityEmailService();

            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
                manager.UserTokenProvider = new DataProtectorTokenProvider<TheatreIdentityUser>(dataProtectionProvider.Create("ASP.NET Identity"));

            return manager;
        }
    }
}
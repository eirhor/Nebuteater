using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Nebuteater.Identity.Infrastructure;
using Nebuteater.Identity.Models;
using Nebuteater.Models.ViewModels.Account;

namespace Nebuteater.Web.Controllers
{
    [Authorize]
    public class AccountController : IdentityControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginViewModel
            {
                Title = "Innlogging",
                Login = new Login(),
                ReturnUrl = returnUrl
            };
            
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await SignInManager.PasswordSignInAsync(model.Login.Email, model.Login.Password, model.Login.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            var model = new ForgotPasswordViewModel
            {
                Title = "Glemt passordet?",
                ForgotPassword = new ForgotPassword()
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await UserManager.FindByNameAsync(model.ForgotPassword.Email);
            if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
            {
                var nullModel = new ForgotPasswordConfirmationViewModel
                {
                    Title = "Vennligst sjekk din e-post",
                    ResetPasswordLink = string.Empty
                };

                return View("ForgotPasswordConfirmation", nullModel);

            }

            var code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
            var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
            await UserManager.SendEmailAsync(user.Id, "Tilbakestill passord", "Tilbakestill passordet ved å klikke her: <a href=\"" + callbackUrl + "\">tilbakestill</a>");

            var confirmModel = new ForgotPasswordConfirmationViewModel
            {
                Title = "Vennligst sjekk din e-post",
                ResetPasswordLink = callbackUrl
            };

            return View("ForgotPasswordConfirmation", confirmModel);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult ResetPassword(string code)
        {
            if (code == null)
                return View("Error");

            var model = new ResetPasswordViewModel
            {
                Title = "Tilbakestill passordet",
                ResetPassword = new ResetPassword
                {
                    Code = code
                }
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await UserManager.FindByNameAsync(model.ResetPassword.Email);
            if (user == null)
                return ResetPasswordConfirmation();

            var result = await UserManager.ResetPasswordAsync(user.Id, model.ResetPassword.Code, model.ResetPassword.Password);
            if (result.Succeeded == false)
            {
                AddErrors(result);
                return View(model);
            }

            return ResetPasswordConfirmation();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult ResetPasswordConfirmation()
        {
            var model = new ResetPasswordConfirmationViewModel
            {
                Title = "Ditt passord er tilbakestilt"
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> SendCode(string returnUrl)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
                return View("Error");

            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            var model = new SendCodeViewModel
            {
                SendCode = new SendCode
                {
                    Providers = factorOptions
                },
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (!await SignInManager.SendTwoFactorCodeAsync(model.SendCode.SelectedProvider))
                return View("Error");

            return RedirectToAction("VerifyCode", new
            {
                Provider = model.SendCode.SelectedProvider,
                ReturnUrl = model.ReturnUrl
            });
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl)
        {
            if (!await SignInManager.HasBeenVerifiedAsync())
                return View("Error");

            var user = await UserManager.FindByIdAsync(await SignInManager.GetVerifiedUserIdAsync());
            if (user == null)
                return View("Error");

            var model = new VerifyCodeViewModel
            {
                Title = "Fyll inn verifiseringskoden",
                ReturnUrl = returnUrl,
                SelectedProvider = provider,
                VerifyCode = new VerifyCode(),
                Code = await UserManager.GenerateTwoFactorTokenAsync(user.Id, provider)
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await SignInManager.TwoFactorSignInAsync(model.SelectedProvider, model.VerifyCode.Code, isPersistent: false, rememberBrowser: model.VerifyCode.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid code.");
                    return View(model);
            }
        }
    }
}
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Nebuteater.Identity.Infrastructure;

namespace Nebuteater.Web.Controllers
{
    public class IdentityControllerBase : Controller
    {
        private TheatreIdentityUserManager _userManager;
        private TheatreIdentitySignInManager _signInManager;

        public TheatreIdentityUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<TheatreIdentityUserManager>();
            }
            private set { _userManager = value; }
        }

        public TheatreIdentitySignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<TheatreIdentitySignInManager>();
            }
            private set { _signInManager = value; }
        }

        public void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        public ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
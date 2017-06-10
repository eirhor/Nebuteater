using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using Nebuteater.Identity;
using Nebuteater.Services;
using Nebuteater.Services.Interfaces;
using Owin;

namespace Nebuteater.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IdentityConfig.ConfigureAuth(app);
        }
    }
}

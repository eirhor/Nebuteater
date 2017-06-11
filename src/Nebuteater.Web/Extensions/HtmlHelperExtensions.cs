using System;
using System.Configuration;
using System.Web.Mvc;

namespace Nebuteater.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static bool IsInDeveloperMode(this HtmlHelper helper)
        {
            var appSetting = ConfigurationManager.AppSettings["DeveloperMode"];

            if (appSetting == null)
                return false;

            return Convert.ToBoolean(appSetting);
        }
    }
}
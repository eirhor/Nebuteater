using System.Collections.Generic;
using System.Web.Mvc;

namespace Nebuteater.Identity.Models
{
    public class ConfigureTwoFactor
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}
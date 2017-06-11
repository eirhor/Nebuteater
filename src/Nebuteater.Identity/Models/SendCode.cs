using System.Collections.Generic;
using System.Web.Mvc;

namespace Nebuteater.Identity.Models
{
    public class SendCode
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
    }
}
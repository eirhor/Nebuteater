using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Epost")]
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}
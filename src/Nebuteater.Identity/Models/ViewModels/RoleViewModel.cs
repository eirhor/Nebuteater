using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Rollenavn")]
        public string Name { get; set; }
    }
}
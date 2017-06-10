using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Epost")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Passord")]
        public string Password { get; set; }

        [Display(Name = "Husk meg?")]
        public bool RememberMe { get; set; }
    }
}
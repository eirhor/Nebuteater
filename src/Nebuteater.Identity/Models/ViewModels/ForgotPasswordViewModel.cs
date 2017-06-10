using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}
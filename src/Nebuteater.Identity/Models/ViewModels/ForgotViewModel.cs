using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}
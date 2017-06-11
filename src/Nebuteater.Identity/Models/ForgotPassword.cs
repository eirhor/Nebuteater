using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}
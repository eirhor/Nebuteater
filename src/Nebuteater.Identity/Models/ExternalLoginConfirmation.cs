using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class ExternalLoginConfirmation
    {
        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class Forgot
    {
        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}
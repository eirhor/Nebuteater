using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Passordet må minst være {2} bokstaver langt.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Passord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekreft passord")]
        [Compare("Password", ErrorMessage = "Passordene er ikke like.")]
        public string ConfirmPassword { get; set; }
    }
}
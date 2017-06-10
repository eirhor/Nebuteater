using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nåværende passord")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Passordet må minst være {2} bokstaver langt.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nytt passord")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekreft passord")]
        [Compare("NewPassword", ErrorMessage = "Passordene er ikke like.")]
        public string ConfirmPassword { get; set; }
    }
}
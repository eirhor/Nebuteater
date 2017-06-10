using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models.ViewModels
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Telefonnummer")]
        public string Number { get; set; }
    }
}
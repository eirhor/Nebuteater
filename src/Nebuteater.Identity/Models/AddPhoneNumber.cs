using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class AddPhoneNumber
    {
        [Required]
        [Phone]
        [Display(Name = "Telefonnummer")]
        public string Number { get; set; }
    }
}
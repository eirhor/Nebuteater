using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class VerifyPhoneNumber
    {
        [Required]
        [Display(Name = "Kode")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }
    }
}
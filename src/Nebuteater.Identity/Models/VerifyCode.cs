using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class VerifyCode
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Kode")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Husk denne nettleseren?")]
        public bool RememberBrowser { get; set; }
    }
}
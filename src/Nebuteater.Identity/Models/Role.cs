using System.ComponentModel.DataAnnotations;

namespace Nebuteater.Identity.Models
{
    public class Role
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Rollenavn")]
        public string Name { get; set; }
    }
}
using Microsoft.AspNet.Identity.EntityFramework;

namespace Nebuteater.Models.Identity
{
    public class User : IdentityUser
    {
        public virtual string Email { get; set; }
        public virtual string PasswordHash { get; set; }
    }
}
using Nebuteater.Identity.Models;
using Nebuteater.Models.ViewModels.Shared;

namespace Nebuteater.Models.ViewModels.Account
{
    public class LoginViewModel : ViewModelBase
    {
        public string ReturnUrl { get; set; }
        public Login Login { get; set; }
    }
}
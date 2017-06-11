using Nebuteater.Identity.Models;
using Nebuteater.Models.ViewModels.Shared;

namespace Nebuteater.Models.ViewModels.Account
{
    public class SendCodeViewModel : ViewModelBase
    {
        public SendCode SendCode { get; set; }
        public string ReturnUrl { get; set; }
    }
}
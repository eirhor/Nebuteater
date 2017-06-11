using Nebuteater.Identity.Models;
using Nebuteater.Models.ViewModels.Shared;

namespace Nebuteater.Models.ViewModels.Account
{
    public class VerifyCodeViewModel : ViewModelBase
    {
        public VerifyCode VerifyCode { get; set; }
        public string ReturnUrl { get; set; }
        public string SelectedProvider { get; set; }
        public string Code { get; set; }
    }
}
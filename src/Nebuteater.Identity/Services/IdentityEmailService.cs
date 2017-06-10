using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Nebuteater.Identity.Services
{
    public class IdentityEmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return Task.FromResult(0);
        }
    }
}
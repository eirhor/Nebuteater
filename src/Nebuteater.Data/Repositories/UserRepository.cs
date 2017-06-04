using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IRepository<User>
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
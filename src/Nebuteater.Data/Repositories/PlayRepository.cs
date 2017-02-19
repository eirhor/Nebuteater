using Nebuteater.Data.Infrastructure;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Repositories
{
    public class PlayRepository : RepositoryBase<Play>, IRepository<Play>
    {
        public PlayRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
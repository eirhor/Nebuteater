using Nebuteater.Data.Infrastructure;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Repositories
{
    public class PerformanceRepository : RepositoryBase<Performance>, IRepository<Performance>
    {
        public PerformanceRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
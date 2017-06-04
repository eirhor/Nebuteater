using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Repositories
{
    public class ReservationRepository : RepositoryBase<Reservation>, IRepository<Reservation>
    {
        public ReservationRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
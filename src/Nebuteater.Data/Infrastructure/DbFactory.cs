using Nebuteater.Data.Contexts;
using Nebuteater.Data.Infrastructure.Interfaces;

namespace Nebuteater.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TheatreDbContext dbContext;

        public TheatreDbContext Init()
        {
            return dbContext ?? (dbContext = new TheatreDbContext());
        }

        protected override void DisposeCore()
        {
            dbContext?.Dispose();
        }
    }
}
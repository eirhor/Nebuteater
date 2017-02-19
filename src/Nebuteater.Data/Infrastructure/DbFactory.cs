using Nebuteater.Data.Contexts;

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
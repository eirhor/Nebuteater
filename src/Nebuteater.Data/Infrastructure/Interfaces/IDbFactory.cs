using Nebuteater.Data.Contexts;

namespace Nebuteater.Data.Infrastructure
{
    public interface IDbFactory
    {
        TheatreDbContext Init();
    }
}
using Nebuteater.Data.Contexts;

namespace Nebuteater.Data.Infrastructure.Interfaces
{
    public interface IDbFactory
    {
        TheatreDbContext Init();
    }
}
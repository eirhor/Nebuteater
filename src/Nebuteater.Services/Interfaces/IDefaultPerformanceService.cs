using System.Collections.Generic;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultPerformanceService
    {
        Performance GetPerformance(int id);
        IEnumerable<Performance> GetAll();
        void Update(Performance performance);
        void Delete(Performance performance);
        void Create(Performance performance);
        void Save();
    }
}
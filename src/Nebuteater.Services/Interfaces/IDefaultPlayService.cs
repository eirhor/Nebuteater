using System.Collections.Generic;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultPlayService
    {
        Play GetPlay(int id);
        IEnumerable<Play> GetAll();
        void Update(Play play);
        void Delete(Play play);
        void Create(Play play);
        void Save();
    }
}
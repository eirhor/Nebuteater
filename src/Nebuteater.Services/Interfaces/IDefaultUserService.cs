using System.Collections.Generic;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetAll();
        void Update(User user);
        void Delete(User user);
        void Create(User user);
        void Save();
    }
}
using System.Collections.Generic;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultRoleService
    {
        Role GetRole(int id);
        IEnumerable<Role> GetAll();
        void Update(Role role);
        void Delete(Role role);
        void Create(Role role);
        void Save();
    }
}
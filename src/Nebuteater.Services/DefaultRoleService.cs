using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultRoleService : IDefaultRoleService
    {
        private readonly IRepository<Role> _repository;

        public DefaultRoleService(IRepository<Role> repository)
        {
            _repository = repository;
        }

        public Role GetRole(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Role role)
        {
            _repository.Update(role);
        }

        public void Delete(Role role)
        {
            _repository.Delete(role);
        }

        public void Create(Role role)
        {
            _repository.Add(role);
        }

        public void Save()
        {
            _repository.Commit();
        }
    }
}
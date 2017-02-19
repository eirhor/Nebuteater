using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultRoleService : IDefaultRoleService
    {
        private readonly IRepository<Role> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DefaultRoleService(IRepository<Role> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();
        }
    }
}
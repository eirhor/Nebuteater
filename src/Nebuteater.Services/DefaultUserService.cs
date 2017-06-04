using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services
{
    public class DefaultUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DefaultUserService(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public User GetUser(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public void Create(User user)
        {
            _repository.Add(user);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
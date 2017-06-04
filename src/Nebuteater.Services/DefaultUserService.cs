using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultUserService : IDefaultUserService
    {
        private readonly IRepository<User> _repository;

        public DefaultUserService(IRepository<User> repository)
        {
            _repository = repository;
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
            _repository.Commit();
        }
    }
}
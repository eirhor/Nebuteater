using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultPerformanceService : IDefaultPerformanceService
    {
        private readonly IRepository<Performance> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DefaultPerformanceService(IRepository<Performance> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Performance GetPerformance(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Performance> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Performance performance)
        {
            _repository.Update(performance);
        }

        public void Delete(Performance performance)
        {
            _repository.Delete(performance);
        }

        public void Create(Performance performance)
        {
            _repository.Add(performance);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
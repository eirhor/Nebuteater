using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultReservationService : IDefaultReservationService
    {
        private readonly IRepository<Reservation> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DefaultReservationService(IRepository<Reservation> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Reservation GetReservation(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Reservation reservation)
        {
            _repository.Update(reservation);
        }

        public void Delete(Reservation reservation)
        {
            _repository.Delete(reservation);
        }

        public void Create(Reservation reservation)
        {
            _repository.Add(reservation);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
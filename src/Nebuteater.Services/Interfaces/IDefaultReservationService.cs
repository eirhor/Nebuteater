using System.Collections.Generic;
using Nebuteater.Models.Entities;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultReservationService
    {
        Reservation GetReservation(int id);
        IEnumerable<Reservation> GetAll();
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        void Create(Reservation reservation);
        void Save();
    }
}
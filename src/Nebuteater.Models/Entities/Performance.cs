using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nebuteater.Models.Enums;

namespace Nebuteater.Models.Entities
{
    public class Performance : EntityBase
    {
        public int PlayId { get; set; }
        public DateTime StartDateTime { get; set; }
        public int MaxAmountOfTickets { get; set; }
        public int FewTicketsLeft { get; set; }
        public Groups Group { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}

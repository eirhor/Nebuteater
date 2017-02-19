namespace Nebuteater.Models.Entities
{
    public class Reservation : EntityBase
    {
        public int PerformanceId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int AmountOfTickets { get; set; }
        public bool HasWheelchar { get; set; }
    }
}
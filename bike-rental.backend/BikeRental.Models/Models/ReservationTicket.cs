using System.Data.Common;

namespace BikeRental.Models.Models
{
    public class ReservationTicket
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public int BicycleId { get; set; }
        public int ReservationId { get; set; }
    }
}
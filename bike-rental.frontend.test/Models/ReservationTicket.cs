namespace bike_rental.frontend.test.Models
{
    public class ReservationTicket
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public int BicycleId { get; set; }
        public int ReservationId { get; set; }
    }
}

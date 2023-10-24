namespace bike_rental.frontend.test.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public int BicycleId { get; set; }
        public Bicycle? Bicycle { get; set; }
    }
}

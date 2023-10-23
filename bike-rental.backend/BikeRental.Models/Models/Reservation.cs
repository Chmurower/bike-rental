namespace BikeRental.Models.Models{
    public class Reservation {
        public int Id { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public Bicycle? Bicycle { get; set; }
    }
}
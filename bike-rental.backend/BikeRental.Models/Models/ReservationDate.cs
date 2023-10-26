namespace BikeRental.Models.Models{
    public class ReservationDate {
        public int Id { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public int BicycleId { get; set; }
        public Bicycle Bicycle { get; set; }
    }
}
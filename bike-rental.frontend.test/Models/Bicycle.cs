namespace bike_rental.frontend.test.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Model { get; set; }
        public int FrameSize { get; set; }
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public DateTime StartService { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsInService { get; set; }
    }
}

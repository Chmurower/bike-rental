namespace BikeRental.Models.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Model { get; set; }
        public int FrameSize { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public DateTime StartService { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsInService { get; set; }
    }
}
namespace BikeRental.Models.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? ModelName { get; set; }
        public int FrameSizeId { get; set; }
        public string? SerialNumber { get; set; }
        public List<ReservationDate>? Reservations { get; set;  }
        public DateTime StartService { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsInService { get; set; }
    }
}
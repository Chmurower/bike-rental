﻿namespace bike_rental.frontend.test.Models
{
    public class ReservationTicket
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdSerial { get; set; }
        public int BicycleId { get; set; }
        public Bicycle? Bicycle { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

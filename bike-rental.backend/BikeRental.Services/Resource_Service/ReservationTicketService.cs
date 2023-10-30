using BikeRental.Models;
using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public class ReservationTicketService : IReservationTicketService
    {
        private readonly RentalDbContext _db;
        public List<ReservationTicket> GetAllReservations()
        {
            var service = _db.ReservationTickets.ToList();
            return service;
        }

        public ReservationTicket GetReservationById(int id)
        {
            var service = _db.ReservationTickets.FirstOrDefault(x => x.Id == id);
            return service;
        }
    }
}

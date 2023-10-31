using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public interface IReservationTicketService
    {
        public List<ReservationTicket> GetAllReservations();
        public ReservationTicket GetReservationById(int id);
    }
}

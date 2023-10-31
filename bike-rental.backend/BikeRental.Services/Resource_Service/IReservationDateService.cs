using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public interface IReservationDateService
    {
        public ReservationDate GetReservationDateById(int id);
    }
}

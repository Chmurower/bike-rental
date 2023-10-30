using BikeRental.Models;
using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    internal class ReservationDateService : IReservationDateService
    {
        private readonly RentalDbContext _db;

        public ReservationDateService(RentalDbContext db)
        {
            _db = db;
        }

        public ReservationDate GetReservationDateById(int id)
        {
            var service = _db.ReservationDates.FirstOrDefault(x => x.Id == id);
            return service;
        }
    }
}

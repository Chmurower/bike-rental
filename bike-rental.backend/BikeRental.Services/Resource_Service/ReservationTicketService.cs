using BikeRental.Models;
using BikeRental.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.Services.Resource_Service
{
    public class ReservationTicketService : IReservationTicketService
    {
        private readonly RentalDbContext _db;
        public ReservationTicketService(RentalDbContext db)
        {
            _db = db;
        }

        // GET
        public List<ReservationTicket> GetAllReservations()
        {
            var service = _db.ReservationTickets
                .Include(b => b.Bicycle) 
                    .ToList();
            return service;
        }

        // GET
        public ReservationTicket GetReservationById(int id)
        {
            var service = _db.ReservationTickets
                .Include(bi => bi.Bicycle)
                    .Include(ca => ca.Bicycle != null ? ca.Bicycle.Category : null)
                            .FirstOrDefault(x => x.Id == id);

            if (service == null)
            {
                return new ReservationTicket();
            }
            if (service.Bicycle == null)
            {
                service.Bicycle = new Bicycle();
            }
            if (service.Bicycle.Category == null)
            {
                service.Bicycle.Category = new Category();
            }
            return service;
        }

        // CREATE
        public ResponseService<ReservationTicket> CreateReservationTicket(ReservationTicket reservation)
        {
            try
            {
                _db.ReservationTickets.Add(reservation);
                // Add
                _db.SaveChanges();
                return new ResponseService<ReservationTicket>
                {
                    IsSucess = true,
                    Message = "Order added.",
                    Time = DateTime.UtcNow,
                    Data = reservation
                };
            }
            catch (Exception e)
            {
                return new ResponseService<ReservationTicket>
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = reservation
                };
            }
        }

    }
}

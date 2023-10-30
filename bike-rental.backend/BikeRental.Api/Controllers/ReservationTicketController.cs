using BikeRental.Services.Resource_Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{
    public class ReservationTicketController : Controller
    {
        private readonly ReservationTicketService _dbReservationTicket;

        public ReservationTicketController(ReservationTicketService dbReservationTicket)
        {
            _dbReservationTicket = dbReservationTicket;
        }

        // GET
        [HttpGet("api/reservationticket/{id}")]
        public IActionResult GetReservationTickedById(int id)
        {
            var reservation = _dbReservationTicket.GetReservationById(id);
            return Ok(reservation);
        }

        // GET
        [HttpGet("api/reservationticket")]
        public IActionResult GetAllReservationTickets()
        {
            var reservations = _dbReservationTicket.GetAllReservations();
            return Ok(reservations);
        }

    }
}

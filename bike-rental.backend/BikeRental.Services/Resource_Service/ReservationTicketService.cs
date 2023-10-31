﻿using BikeRental.Models;
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

        public List<ReservationTicket> GetAllReservations()
        {
            var service = _db.ReservationTickets.ToList();
            return service;
        }

        public ReservationTicket GetReservationById(int id)
        {
            var service = _db.ReservationTickets
                .Include(bi => bi.Bicycle)
                    .Include(ca => ca.Bicycle.Category)
                            .FirstOrDefault(x => x.Id == id);
            return service;
        }
    }
}

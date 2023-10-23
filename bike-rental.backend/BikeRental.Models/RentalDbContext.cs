﻿using BikeRental.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental.Models
{
    public class RentalDbContext : DbContext
    {
       public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
        {
        }
        
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Category> Categorys { get; set; } 
        public DbSet<FrameSize> FrameSizes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationTicket> ReservationTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LUKMAINHUB\\SQLEXPRESS;Database=BikeRental;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}

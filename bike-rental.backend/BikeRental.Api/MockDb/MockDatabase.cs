using BikeRental.Models.Models;

namespace BikeRental.Api.MockDb
{
    public class MockDatabase
    {
        // Mock database - CATEGORYs
        internal readonly List<Category> categories = new List<Category>()
        {
            new Category
            {
                Id = 0,
                Type = "City"
            },
            new Category
            {
                Id = 1,
                Type = "Mountain Bike"
            },
            new Category
            {
                Id = 2,
                Type = "Gravel"
            }
        };

        // Mock database - BICYCLEs
        internal readonly List<Bicycle> bicycles = new List<Bicycle>()
        {
            new Bicycle
            {
                Id = 0,
                CategoryId = 0,
                Category = null,
                ModelName = "CityMe",
                FrameSizeId = 1,
                SerialNumber = "A0000",
                //Reservations = new Reservation(){ };
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = true,
                IsInService = false
            },

            new Bicycle
            {
                Id = 1,
                CategoryId = 1,
                Category = null,
                ModelName = "GT Zaskar",
                FrameSizeId = 1,
                SerialNumber = "A0001",
                //Reservations = new Reservation(){ };
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = true,
                IsInService = false
            },

            new Bicycle
            {
                Id = 2,
                CategoryId = 1,
                Category = null,
                ModelName = "Giant Rock",
                FrameSizeId = 1,
                SerialNumber = "A0002",
                //Reservations = new Reservation(){ };
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = true,
                IsInService = false
            },
            new Bicycle
            {
                Id = 3,
                CategoryId = 1,
                Category = null,
                ModelName = "Author Basic",
                FrameSizeId = 1,
                SerialNumber = "A0003",
                //Reservations = new Reservation(){ };
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = false,
                IsInService = true
            },
            new Bicycle
            {
                Id = 4,
                CategoryId = 2,
                Category = null,
                ModelName = "FBM partymaster",
                FrameSizeId = 1,
                SerialNumber = "A0004",
                //Reservations = new Reservation(){ };
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = false,
                IsInService = true
            },
        };

        // Mock database - BICYCLEs
        internal readonly List<FrameSize> framesizes = new List<FrameSize>()
        {
            new FrameSize
            {
                Id = 0,
                Size = 15
            },
            new FrameSize
            {
                Id = 1,
                Size = 18
            },
            new FrameSize
            {
                Id = 1,
                Size = 19
            },
            new FrameSize
            {
                Id = 1,
                Size = 20
            },
            new FrameSize
            {
                Id = 1,
                Size = 21
            },
        };

        // Mock database - RESERVATIONs
        internal readonly List<ReservationDate> reservations = new List<ReservationDate>()
        {
            new ReservationDate
            {
                Id = 0,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 0,
               // Bicycle = null
            },
            new ReservationDate
            {
                Id = 1,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 1,
               // Bicycle = null
            },
            new ReservationDate
            {
                Id = 2,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 2,
               // Bicycle = null
            },
            new ReservationDate
            {
                Id = 3,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 1,
               // Bicycle = null
            },
            new ReservationDate
            {
                Id = 4,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 2,
               // Bicycle = null
            },
            new ReservationDate
            {
                Id = 5,
                StartReservation = Convert.ToDateTime("2023-12-10"),
                EndReservation = Convert.ToDateTime("2023-12-11"),
                BicycleId = 1,
               // Bicycle = null
            },
        };

        // Mock database - RESERVATIONTICKETs
        internal readonly List<ReservationTicket> reservationTickets = new List<ReservationTicket>() 
        { 
            new ReservationTicket
            {
                Id = 0,
                CustomerName = "Pawel",
                BicycleId = 0,
                ReservationId = 0
            },
            new ReservationTicket
            {
                Id = 1,
                CustomerName = "Jacek",
                BicycleId = 1,
                ReservationId = 1
            },
            new ReservationTicket
            {
                Id = 2,
                CustomerName = "Lukasz",
                BicycleId = 2,
                ReservationId = 2
            },
        };

    }
}



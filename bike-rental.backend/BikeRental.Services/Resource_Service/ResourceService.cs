using BikeRental.Models;
using BikeRental.Models.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BikeRental.Services.Resource_Service
{
    public class ResourceService : IResourceService
    {
        private readonly RentalDbContext _db;

        public ResourceService(RentalDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Returns list of all bicycles including subobjects
        /// </summary>
        /// <returns></returns>
        public List<Bicycle> GetAllBikes()
        {
            var service = _db.Bicycles
                    .Include(c => c.Category)
                        .Include(fs => fs.FrameSize)
                            .ToList();
            return service;
        }

        /// <summary>
        /// Returns list of bicycles which are available for rent includeing all subobjects
        /// </summary>
        /// <returns>List<Bicycle></returns>
        public List<Bicycle> GetAllBikesReadyToRent()
        {
            var service = _db.Bicycles
                .Where(a => a.IsAvailable == true)
                    .Include(c => c.Category)
                        .Include(fs => fs.FrameSize)
                            .ToList();
            return service;
        }

        public Bicycle GetBikeById(int id)
        {
            var service = _db.Bicycles.FirstOrDefault(x => x.Id == id);
            return service ?? new Bicycle();
        }

        /// <summary>
        /// Update bicycle data
        /// </summary>
        /// <param name="bicycle">Bicycle object</param>
        /// <returns>ResponseService object</returns>
        public ResponseService<bool> UpdateBikeData(Bicycle bicycle)
        {
            try
            {
                _db.Bicycles.Update(bicycle);
                _db.SaveChanges();
                return new ResponseService<bool>
                {
                    IsSucess = true,
                    Message = "Bicycle object updated.",
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch(Exception e)
            {
                return new ResponseService<bool>
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
        }

        public ResponseService<bool> CeateNewBike(Bicycle bicycle)
        {
            try
            {
                //if (bicycle.Category == null)
                //{
               //     bicycle.Category = new();
                //}
                //if (bicycle.Reservations == null)
                //{
                //    bicycle.Reservations = new();
                //}

                _db.Bicycles.Add(bicycle);
                _db.SaveChanges();
                return new ResponseService<bool>
                {
                    IsSucess = true,
                    Message = "Bicycle object updated.",
                    Time = DateTime.UtcNow,
                    Data = true
                };

            }
            catch(Exception e)
            {
                return new ResponseService<bool>
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
        }

    }
}
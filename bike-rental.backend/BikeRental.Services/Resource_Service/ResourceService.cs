using BikeRental.Models;
using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public class ResourceService : IResourceService
    {
        private readonly RentalDbContext _db;

        public ResourceService(RentalDbContext db)
        {
            _db = db;
        }

        public List<Bicycle> GetAllBikes()
        {
            var service = _db.Bicycles.ToList();
            return service;
        }

        /// <summary>
        /// Returns list of bicycles which are available for rent
        /// </summary>
        /// <returns>List<Bicycle></returns>
        public List<Bicycle> GetAllBikesReadyToRent()
        {
            var service = _db.Bicycles
                .Where(a => a.IsAvailable == true)
                    .ToList();
            return service;
        }

        public Bicycle GetBikeById(int id)
        {
            var service = _db.Bicycles.FirstOrDefault(x => x.Id == id);
            return service;
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

        /// <summary>
        /// Finishing bicycle service by status change of bicycle by id 
        /// </summary>
        /// <param name="id">bicycle id</param>
        /// <returns>ResponseService object</returns>
        public ResponseService<bool> FinishBicycleServiceById(int id)
        {
            var bicycle = _db.Bicycles.Find(id);
            bicycle.IsInService = false;
            bicycle.IsAvailable = true;
            bicycle.StartService = DateTime.UtcNow.AddDays(30);

            return UpdateBikeData(bicycle);
        }

        /// <summary>
        /// Sending bicycle to service and status change of bicycle by bicycle id 
        /// </summary>
        /// <param name="id">bicycle id</param>
        /// <returns>ResponseService object</returns>
        public ResponseService<bool> SendBicycleToServiceById(int id)
        {
            var bicycle = _db.Bicycles.Find(id);
            bicycle.IsInService = true;
            bicycle.IsAvailable = false;

            return UpdateBikeData(bicycle);
        }


    }
}
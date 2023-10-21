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

        public Bicycle GetBikeById(int id)
        {
            var service = _db.Bicycles.FirstOrDefault(x => x.Id == id);
            return service;
        }

        public void UpdateBikeData(Bicycle bicycle)
        {
            _db.Bicycles.Update(bicycle);
            _db.SaveChanges();
        }
    }
}
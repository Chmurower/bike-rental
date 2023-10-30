using BikeRental.Models;
using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public class FramesizeService : IFramesizeService
    {
        private readonly RentalDbContext _db;

        public FramesizeService(RentalDbContext db)
        {
            _db = db;
        }

        public List<FrameSize> GetAllFramesizes()
        {
            var service = _db.FrameSizes.ToList();
            return service;
        }

        public FrameSize GetFrameSizeById(int id)
        {
            var service = _db.FrameSizes.FirstOrDefault(x => x.Id == id);
            return service;
        }
    }
}

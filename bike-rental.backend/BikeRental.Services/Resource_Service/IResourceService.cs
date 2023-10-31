using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public interface IResourceService
    {
         // READ
         public List<Bicycle> GetAllBikes();
         public Bicycle GetBikeById(int id);

         // UPDATE
         public ResponseService<bool> UpdateBikeData(Bicycle bicycle);
    }
}
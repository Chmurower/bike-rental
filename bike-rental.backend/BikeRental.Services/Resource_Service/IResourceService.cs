using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public interface IResourceService
    {
         // READ
         public List<Bicycle> GetAllBikes();
         public Bicycle GetBikeById(int id);

         // UPDATE
         public void UpdateBikeData(Bicycle bicycle);
    }
}
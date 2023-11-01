using BikeRental.Services.Resource_Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly ResourceService _dbResource;

        public ResourceController(ResourceService dbResource)
        {
            _dbResource = dbResource;
        }

        // GET
        [HttpGet("api/bike")]
        public IActionResult GetAllBikes()
        {
            var _bicycles = _dbResource.GetAllBikes();
            return Ok(_bicycles);
        } 

        // GET
        [HttpGet("api/bike/{id}")]
        public IActionResult GetBikeById(int id)
        {
            var service = _dbResource.GetBikeById(id);
            return Ok(service);
        }

        // PATCH
        [HttpPatch("api/bike/toservice/{id}")]
        public IActionResult SendBicycletoServiceByBicycleId(int id)
        {
            var service = _dbResource.SendBicycleToServiceById(id);
            return Ok(service);
        }
    }
}

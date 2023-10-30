using BikeRental.Services.Resource_Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{
    [ApiController]
    public class ServiceController : Controller
    {
        private readonly ResourceService _dbResource;

        public ServiceController(ResourceService dbResource)
        {
            _dbResource = dbResource;
        }

        // GET
        [HttpGet("api/service")]
        public IActionResult GetAllBikesInService()
        {
            var service = _dbResource.GetAllBikes()
                .Where(i => i.IsInService == true)
                .ToList();
           return Ok(service);
        }
    }
}

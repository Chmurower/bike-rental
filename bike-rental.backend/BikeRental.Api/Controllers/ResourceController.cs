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

        /*
        // GET
        [HttpGet("api/category")]
        public IActionResult GetAllCategories()
        {
            var _categories = _dbMock.categories;
            return Ok(_categories);
        }

        // GET
        [HttpGet("api/category/{id}")]
        public IActionResult GetAllCategories(int id)
        {
            var service = _dbMock.categories.Where(i => i.Id == id).FirstOrDefault();
            return Ok(service);
        }
        */

        // GET
        [HttpGet("api/bike")]
        public IActionResult GetAllBikes()
        {
            var _bicycles = _dbResource.GetAllBikes();
            return Ok(_bicycles);
        }

        // GET
        [HttpGet("api/bike/{id}")]
        public IActionResult GetAllBikes(int id)
        {
            var service = _dbResource.GetBikeById(id);
            return Ok(service);
        }
    }
}

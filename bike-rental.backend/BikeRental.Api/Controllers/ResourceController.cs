using BikeRental.Services.Resource_Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{   
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IResourceService _resourceService;

        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        // GET
        [HttpGet("api/resources")]
        public ActionResult GetAllResources()
        {
            var bicycles = _resourceService.GetAllBikes();
            return Ok(bicycles);
        }

        // GET
        [HttpGet("api/resources/{id}")]
        public ActionResult GetResourceById(int id)
        {
            var bicycles = _resourceService.GetBikeById(id);
            return Ok(bicycles);
        }
        
    }
}
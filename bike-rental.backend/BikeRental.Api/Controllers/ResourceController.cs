using BikeRental.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{
    [ApiController]
    public class ResourceController : ControllerBase
    {
        // Mock database
        private readonly List<Category> _categories = new List<Category>()
        {
            new Category
            {
                Id = 0,
                Type = "City"
            },
            new Category
            {
                Id = 1,
                Type = "Mountain Bike"
            },
            new Category
            {
                Id = 2,
                Type = "Gravel"
            }
        };

        // Mock database
        private readonly List<Bicycle> _bicycles = new List<Bicycle>()
        {
            new Bicycle
            {
                Id = 0,
                CategoryId = 0,
                Model = "CityMe",
                FrameSize = 19,
                StartReservation = Convert.ToDateTime("2023-05-22"),
                EndReservation = Convert.ToDateTime("2023-05-22"),
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = true,
                IsInService = false
            },

            new Bicycle
            {
                Id = 1,
                CategoryId = 1,
                Model = "GT Zaskar",
                FrameSize = 15,
                StartReservation = Convert.ToDateTime("2023-06-21"),
                EndReservation = Convert.ToDateTime("2023-06-22"),
                StartService = Convert.ToDateTime("2023-10-11"),
                IsAvailable = true,
                IsInService = false
            },

            new Bicycle
            {
                Id = 2,
                CategoryId = 2,
                Model = "Giant",
                FrameSize = 18,
                StartReservation = Convert.ToDateTime("2023-09-21"),
                EndReservation = Convert.ToDateTime("2023-09-22"),
                StartService = Convert.ToDateTime("2023-10-13"),
                IsAvailable = true,
                IsInService = false
            },
        };

        // GET
        [HttpGet("api/category")]
        public IActionResult GetAllCategories()
        {
            return Ok(_categories);
        }

        // GET
        [HttpGet("api/category/{id}")]
        public IActionResult GetAllCategories(int id)
        {
            var service = _categories.Where(i => i.Id == id).FirstOrDefault();
            return Ok(service);
        }

        // GET
        [HttpGet("api/bike")]
        public IActionResult GetAllBikes()
        {
            return Ok(_bicycles);
        }

        // GET
        [HttpGet("api/bike/{id}")]
        public IActionResult GetAllBikes(int id)
        {
            var service = _bicycles.Where(i => i.Id == id).FirstOrDefault();
            return Ok(service);
        }
    }
}

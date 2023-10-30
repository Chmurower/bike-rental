using BikeRental.Services.Resource_Service;
using Microsoft.AspNetCore.Mvc;

namespace BikeRental.Api.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _dbCategory;

        public CategoryController(CategoryService dbCategory)
        {
            _dbCategory = dbCategory;
        }

        // GET
        [HttpGet("api/category")]
        public IActionResult GetAllCategories()
        {
            var categories = _dbCategory.GetAllCategories().ToList();
            return Ok(categories);
        }

        // GET
        [HttpGet("api/category/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _dbCategory.GetCategoryById(id);
            return Ok(category);
        }
    }
}

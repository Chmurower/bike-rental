using BikeRental.Models;
using BikeRental.Models.Models;

namespace BikeRental.Services.Resource_Service
{
    public class CategoryService : ICategoryService
    {
        private readonly RentalDbContext _db;

        public CategoryService(RentalDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAllCategories()
        {
            var service = _db.Categorys.ToList();
            return service;
        }

        public Category GetCategoryById(int id)
        {
            var service = _db.Categorys.FirstOrDefault(x => x.Id == id);

            return service ?? new Category();
        }
    }
}

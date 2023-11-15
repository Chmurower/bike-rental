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

        /// <summary>
        /// Returns List of categories.
        /// </summary>
        /// <returns>List of Category objects.</returns>
        public List<Category> GetAllCategories()
        {
            var service = _db.Categorys.ToList();
            return service;
        }

        /// <summary>
        /// Returns Category object by category id.
        /// </summary>
        /// <param name="id">category object id.</param>
        /// <returns>Category object.</returns>
        public Category GetCategoryById(int id)
        {
            var service = _db.Categorys.FirstOrDefault(x => x.Id == id);

            return service ?? new Category();
        }
    }
}

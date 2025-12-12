using WebCatalog.Models;

namespace WebCatalog.Services.Interfaces
{
    public interface CategoryServiceInterface
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetParentCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Category>> GetCategoryByNameAsync(string Name);
    }
}

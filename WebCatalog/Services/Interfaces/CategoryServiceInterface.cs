using WebCatalog.Models;

namespace WebCatalog.Services.Interfaces
{
    public interface CategoryServiceInterface
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetParentCategoriesAsync();
    }
}

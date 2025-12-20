using WebCatalog.DTOs.Requests;
using WebCatalog.Models;

namespace WebCatalog.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetParentCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Category>> GetCategoryByNameAsync(string Name);
        Task<Category> AddCategoryAsync(CategoryCreatDto categoryDto);
        Task<bool> DeleteAsync(int id);
        Task<Category?> UpdateCategoryAsync(Category category);

    }
}

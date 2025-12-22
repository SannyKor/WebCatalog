using WebCatalog.DTOs.Requests;
using WebCatalog.DTOs.Responses;
using WebCatalog.Models;

namespace WebCatalog.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<IEnumerable<CategoryDto>> GetParentCategoriesAsync();
        Task<CategoryDto?> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Category>> GetCategoryByNameAsync(string Name);
        Task<int> AddCategoryAsync(CategoryCreateDto categoryDto);
        Task<bool> DeleteAsync(int id);
        Task<Category?> UpdateCategoryAsync(Category category);

    }
}

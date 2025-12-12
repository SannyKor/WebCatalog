using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebCatalog.Data;
using WebCatalog.Models;
using WebCatalog.Services.Interfaces;

namespace WebCatalog.Services.Implementations
{
    public class CategoryService : CategoryServiceInterface
    {
        private readonly CatalogDbContext _context;
        public CategoryService(CatalogDbContext context)
        { _context = context; }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task<IEnumerable<Category>> GetParentCategoriesAsync()
        {
            return await _context.Categories.Where(c => c.ParentId == null).ToListAsync();
        }
        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }
        public async Task<IEnumerable<Category>> GetCategoryByNameAsync(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return Enumerable.Empty<Category>();

            return await _context.Categories
                .Where(c => c.Name.ToLower().Contains(Name.ToLower()))
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<Category> AddCategoryAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) { return false; }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;                    
        }
        public async Task<Category?> UpdateCategoryAsync(Category category)
        {
            var existingCategory = await _context.Categories.FindAsync(category.Id);
            { if (existingCategory == null) { return null; } }
            existingCategory.Name = category.Name;
            existingCategory.ParentId = category.ParentId;
            exi
        }
    }
}

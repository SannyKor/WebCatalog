using Microsoft.EntityFrameworkCore;
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


    }
}

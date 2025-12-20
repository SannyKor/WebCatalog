using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCatalog.DTOs.Requests;
using WebCatalog.Services.Implementations;
namespace WebCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task <IActionResult> CreatCategory(CategoryCreatDto categoryDto)
        {
            _categoryService.AddCategoryAsync (categoryDto);
            return Ok(categoryDto);
        }

    }
}

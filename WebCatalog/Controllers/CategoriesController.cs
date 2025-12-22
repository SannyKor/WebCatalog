using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCatalog.DTOs.Requests;
using WebCatalog.DTOs.Responses;
using WebCatalog.Services.Implementations;
using WebCatalog.Services.Interfaces;
namespace WebCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryCreateDto categoryDto)
        {
            var newCategoryId = await _categoryService.AddCategoryAsync(categoryDto);
            return Ok(new { id = newCategoryId });
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetById(int id)
        {
            var categoryDto = await _categoryService.GetCategoryByIdAsync(id);
            if (categoryDto == null)
            {
                return NotFound();
            }
            return Ok(categoryDto);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategoriesDto()
        {
            var catogoriesDto = await _categoryService.GetAllAsync();
            return Ok(catogoriesDto);
        }
        [HttpGet("parents")]
        public async Task<ActionResult<IEnumerable<CategoryCreateDto>>> GetAllParentCategoriesDto()
        {
            var catogoriesDto = await _categoryService.GetParentCategoriesAsync();
            return Ok(catogoriesDto);
        }
    }

}

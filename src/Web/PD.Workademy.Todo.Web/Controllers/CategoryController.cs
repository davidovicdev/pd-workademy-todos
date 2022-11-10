using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class CategoryController : ApiBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(
            ICategoryService categoryService,
            ILogger<CategoryController> logger
        )
        {
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategoryAsync(Guid guid)
        {
            return Ok(_categoryService.GetCategory(guid));
        }

        [HttpGet("/Categories")]
        public async Task<ActionResult> GetCategoriesAsync()
        {
            _logger.LogInformation("Evo ti sve kategorije");
            return Ok(_categoryService.GetCategories());
        }

        [HttpPost]
        public async Task<ActionResult> AddCategoryAsync(
            [FromBody] AddUpdateCategoryDTO newCategory
        )
        {
            return Ok(_categoryService.AddCategory(newCategory));
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateCategoryAsync(CategoryDTO updatedCategory)
        {
            return Ok(_categoryService.UpdateCategory(updatedCategory));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCategoryAsync(Guid guid)
        {
            return Ok(_categoryService.DeleteCategory(guid));
        }
    }
}

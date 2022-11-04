using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class CategoryController : ApiBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategoryAsync(Guid guid)
        {
            return Ok(_categoryService.GetCategory(guid));
        }

        [HttpGet("/Categories")]
        public async Task<ActionResult> GetCategoriesAsync()
        {
            return Ok(_categoryService.GetCategories());
        }

        [HttpPost]
        public async Task<ActionResult> AddCategoryAsync([FromBody] CategoryDTO newCategory)
        {
            return Ok(_categoryService.AddCategory(newCategory));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCategoryAsync(Guid guid, CategoryDTO updatedCategory)
        {
            return Ok(_categoryService.UpdateCategory(guid, updatedCategory));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCategoryAsync(Guid guid)
        {
            return Ok(_categoryService.DeleteCategory(guid));
        }
    }
}

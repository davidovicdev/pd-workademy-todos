using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class CategoryController : ApiBaseController
    {
        [HttpGet("/get/{id}")]
        public async Task<ActionResult> GetCategoryAsync(Guid guid)
        {
            CategoryDTO category = new(guid, "Easy");
            return Ok(category);
        }

        [HttpGet("/getAll")]
        public async Task<ActionResult> GetCategoriesAsync()
        {
            List<CategoryDTO> categories =
                new()
                {
                    new CategoryDTO(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                    new CategoryDTO(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                    new CategoryDTO(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard"),
                };
            return Ok(categories);
        }

        [HttpPost("/add")]
        public async Task<ActionResult> AddCategoryAsync([FromBody] CategoryDTO newCategory)
        {
            List<CategoryDTO> existingCategories =
                new()
                {
                    new CategoryDTO(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                    new CategoryDTO(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                    new CategoryDTO(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard")
                };
            existingCategories.Add(newCategory);
            return Ok(existingCategories);
        }

        [HttpPut("/update/{id}")]
        public async Task<ActionResult> UpdateCategoryAsync(Guid guid, CategoryDTO updatedCategory)
        {
            List<CategoryDTO> existingCategories =
                new()
                {
                    new CategoryDTO(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                    new CategoryDTO(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                    new CategoryDTO(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard")
                };
            CategoryDTO categoryToUpdate = existingCategories.Find(x => x.Id == guid);
            categoryToUpdate.Id = updatedCategory.Id;
            categoryToUpdate.Name = updatedCategory.Name;
            return Ok(categoryToUpdate);
        }

        [HttpDelete("/delete/{id}")]
        public async Task<ActionResult> DeleteCategoryAsync(Guid guid)
        {
            List<CategoryDTO> existingCategories =
                new()
                {
                    new CategoryDTO(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                    new CategoryDTO(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                    new CategoryDTO(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard")
                };
            CategoryDTO categoryToDelete = existingCategories.Find(x => x.Id == guid);
            existingCategories.Remove(categoryToDelete);
            return Ok(existingCategories);
        }
    }
}

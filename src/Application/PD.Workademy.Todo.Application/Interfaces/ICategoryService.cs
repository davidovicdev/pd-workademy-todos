using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetCategories();
        CategoryDTO GetCategory(Guid guid);
        CategoryDTO UpdateCategory(CategoryDTO category);
        CategoryDTO DeleteCategory(Guid guid);
        CategoryDTO AddCategory(AddUpdateCategoryDTO category);
    }
}

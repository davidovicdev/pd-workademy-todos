using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetCategories();
        CategoryDTO GetCategory(Guid guid);
        CategoryDTO UpdateCategory(Guid guid, CategoryDTO category);
        CategoryDTO DeleteCategory(Guid guid);
        CategoryDTO AddCategory(CategoryDTO category);
    }
}

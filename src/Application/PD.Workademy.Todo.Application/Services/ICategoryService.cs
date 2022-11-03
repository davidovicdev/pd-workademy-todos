using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
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

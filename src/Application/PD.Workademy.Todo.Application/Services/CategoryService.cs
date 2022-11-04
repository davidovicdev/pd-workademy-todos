using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            _categoryRepository.AddCategory(new Category(category.Id, category.Name));
            return category;
        }

        public CategoryDTO DeleteCategory(Guid guid)
        {
            Category categoryToDelete = _categoryRepository.DeleteCategory(guid);
            CategoryDTO categoryDTO = new(categoryToDelete.Id, categoryToDelete.Name);
            return categoryDTO;
        }

        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = _categoryRepository.GetCategories();
            IEnumerable<CategoryDTO> categoriesDTO = categories.Select(
                x => new CategoryDTO(x.Id, x.Name)
            );
            return categoriesDTO;
        }

        public CategoryDTO GetCategory(Guid guid)
        {
            Category category = _categoryRepository.GetCategory(guid);
            CategoryDTO categoryDTO = new(category.Id, category.Name);
            return categoryDTO;
        }

        public CategoryDTO UpdateCategory(Guid guid, CategoryDTO updatedCategory)
        {
            Category categoryToUpdate = new(updatedCategory.Id, updatedCategory.Name);
            _categoryRepository.UpdateCategory(guid, categoryToUpdate);
            CategoryDTO categoryDTO = new(categoryToUpdate.Id, categoryToUpdate.Name);
            return categoryDTO;
        }
    }
}

using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository cat)
        {
            _categoryRepository = cat;
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            _categoryRepository.AddCategory(new Category(category.Id, category.Name));
            return category;
        }

        public CategoryDTO DeleteCategory(Guid guid)
        {
            Category categoryToDelete = _categoryRepository.DeleteCategory(guid);
            return new CategoryDTO(categoryToDelete.Id, categoryToDelete.Name);
        }

        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = _categoryRepository.GetCategories();
            return categories.Select(x => new CategoryDTO(x.Id, x.Name));
        }

        public CategoryDTO GetCategory(Guid guid)
        {
            Category category = _categoryRepository.GetCategory(guid);
            return new CategoryDTO(category.Id, category.Name);
        }

        public CategoryDTO UpdateCategory(Guid guid, CategoryDTO updatedCategory)
        {
            Category categoryToUpdate = new(updatedCategory.Id, updatedCategory.Name);
            _categoryRepository.UpdateCategory(guid, categoryToUpdate);
            return new CategoryDTO(categoryToUpdate.Id, categoryToUpdate.Name);
        }
    }
}

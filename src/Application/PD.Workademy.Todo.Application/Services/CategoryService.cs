using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public static List<Category> categories =
            new()
            {
                new Category(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                new Category(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                new Category(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard"),
            };

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            Category newCategory = new(category.Id, category.Name);
            categories.Add(newCategory);
            return category;
        }

        public CategoryDTO DeleteCategory(Guid guid)
        {
            Category deletedCategory = categories.Find(x => x.Id == guid);
            CategoryDTO deletedCategoryDTO = new(deletedCategory.Id, deletedCategory.Name);
            categories.Remove(deletedCategory);
            return deletedCategoryDTO;
        }

        public IEnumerable<CategoryDTO> GetCategories()
        {
            return categories.Select(x => new CategoryDTO(x.Id, x.Name));
        }

        public CategoryDTO GetCategory(Guid guid)
        {
            Category category = categories.Find(x => x.Id == guid);
            CategoryDTO categoryDTO = new(category.Id, category.Name);
            return categoryDTO;
        }

        public CategoryDTO UpdateCategory(Guid guid, CategoryDTO updatedCategory)
        {
            Category category = categories.Find(x => x.Id == guid);
            category.Id = updatedCategory.Id;
            category.Name = updatedCategory.Name;
            return updatedCategory;
        }
    }
}

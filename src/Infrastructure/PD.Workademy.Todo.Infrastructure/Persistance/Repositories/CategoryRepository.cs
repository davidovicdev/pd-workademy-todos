using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public static List<Category> categories =
            new()
            {
                new Category(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                new Category(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                new Category(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard"),
            };

        public Category AddCategory(Category category)
        {
            categories.Add(category);
            return category;
        }

        public Category DeleteCategory(Guid guid)
        {
            Category categoryToDelete = categories.Find(x => x.Id == guid);
            categories.Remove(categoryToDelete);
            return categoryToDelete;
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategory(Guid guid)
        {
            Category category = categories.Find(x => x.Id == guid);
            return category;
        }

        public Category UpdateCategory(Guid guid, Category updatedCategory)
        {
            var category = categories.Find(x => x.Id == guid);
            category.Id = updatedCategory.Id;
            category.Name = updatedCategory.Name;
            return updatedCategory;
        }
    }
}

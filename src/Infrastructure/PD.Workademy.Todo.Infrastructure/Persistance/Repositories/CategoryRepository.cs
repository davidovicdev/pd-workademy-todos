using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public Category DeleteCategory(Guid guid)
        {
            try
            {
                Category categoryToDelete = _dbContext.Categories.FirstOrDefault(x => x.Id == guid);
                _dbContext.Categories.Remove(categoryToDelete);
                _dbContext.SaveChanges();
                return categoryToDelete;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories;
        }

        public Category GetCategory(Guid guid)
        {
            Category? category = _dbContext.Categories.FirstOrDefault(x => x.Id == guid);
            return category;
        }

        public Category UpdateCategory(Guid guid, Category updatedCategory)
        {
            var category = _dbContext.Categories.FirstOrDefault(x => x.Id == guid);
            category.Id = updatedCategory.Id;
            category.Name = updatedCategory.Name;
            _dbContext.SaveChanges();
            return updatedCategory;
        }
    }
}

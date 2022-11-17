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
            Category categoryToDelete = _dbContext.Categories.FirstOrDefault(x => x.Id == guid);
            _dbContext.Todoitems.RemoveRange(_dbContext.Todoitems.Where(x => x.Category.Id == guid));
            _dbContext.Categories.Remove(categoryToDelete);
            _dbContext.SaveChanges();
            return categoryToDelete;
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

        public Category UpdateCategory(Category updatedCategory)
        {
            var category = _dbContext.Categories.FirstOrDefault(x => x.Id == updatedCategory.Id);
            category.Id = updatedCategory.Id;
            category.Name = updatedCategory.Name;
            _dbContext.SaveChanges();
            return updatedCategory;
        }
    }
}

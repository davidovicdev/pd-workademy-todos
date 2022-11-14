using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
#nullable disable
namespace PD.Workademy.Todo.Infrastructure.Persistance.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TodoItemRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TodoItem AddTodoItem(TodoItem todoItem)
        {
            _dbContext.Todoitems.Add(todoItem);
            _dbContext.SaveChanges();
            return todoItem;
        }

        public TodoItem DeleteTodoItem(Guid guid)
        {
            TodoItem todoItemToDelete = _dbContext.Todoitems
                .Include(x => x.Category)
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == guid);
            _dbContext.Todoitems.Remove(todoItemToDelete);
            _dbContext.SaveChanges();
            return todoItemToDelete;
        }

        public TodoItem GetTodoItem(Guid guid)
        {
            TodoItem todoItem = _dbContext.Todoitems
                .Include(x => x.Category)
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == guid);
            return todoItem;
        }

        public IEnumerable<TodoItem> GetTodoItemsSPS(
            string search,
            string sortBy,
            int page,
            int perPage
        )
        {
            var todoItems = _dbContext.Todoitems
                .Include(x => x.Category)
                .Include(x => x.User)
                .OrderBy(x => x[sortBy])
                .Where(
                    x =>
                        x.Title.Contains(search)
                        || x.Description.Contains(search)
                        || x.Category.Name.Contains(search)
                        || x.User.FirstName.Contains(search)
                        || x.User.LastName.Contains(search)
                )
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();
            return todoItems;
        }

        public TodoItem UpdateTodoItem(TodoItem todoItem)
        {
            TodoItem updatedTodoItem = _dbContext.Todoitems.FirstOrDefault(
                x => x.Id == todoItem.Id
            );
            updatedTodoItem.Title = todoItem.Title;
            updatedTodoItem.Description = todoItem.Description;
            updatedTodoItem.ChangeStatus(todoItem.IsDone);
            updatedTodoItem.Category = todoItem.Category;
            updatedTodoItem.User = todoItem.User;
            updatedTodoItem.Title = todoItem.Title;
            _dbContext.SaveChanges();
            return updatedTodoItem;
        }
    }
}

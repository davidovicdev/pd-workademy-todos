using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;

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

        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _dbContext.Todoitems.Include(x => x.Category).Include(x => x.User);
        }

        public TodoItem UpdateTodoItem(TodoItem todoItem)
        {
            TodoItem updatedTodoItem = _dbContext.Todoitems.FirstOrDefault(
                x => x.Id == todoItem.Id
            );
            updatedTodoItem.Title = todoItem.Title;
            updatedTodoItem.Description = todoItem.Description;
            updatedTodoItem.ChangeStatus(todoItem.IsDone);
            updatedTodoItem.User = todoItem.User;
            updatedTodoItem.Title = todoItem.Title;
            _dbContext.SaveChanges();
            return updatedTodoItem;
        }
    }
}

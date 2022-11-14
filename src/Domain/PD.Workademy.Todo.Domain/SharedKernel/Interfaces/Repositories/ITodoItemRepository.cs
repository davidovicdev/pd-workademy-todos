using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface ITodoItemRepository
    {
        IEnumerable<TodoItem> GetTodoItems();
        IEnumerable<TodoItem> GetTodoItemsSPS(int page, string sortBy, string search);
        TodoItem UpdateTodoItem(TodoItem todoItem);
        TodoItem GetTodoItem(Guid guid);
        TodoItem DeleteTodoItem(Guid guid);
        TodoItem AddTodoItem(TodoItem todoItem);
    }
}

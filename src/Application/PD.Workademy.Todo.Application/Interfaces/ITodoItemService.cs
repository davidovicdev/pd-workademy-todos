using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Interfaces
{
    public interface ITodoItemService
    {
        IEnumerable<TodoItemDTO> GetTodoItems();
        TodoItemDTO UpdateTodoItem(UpdateTodoItemDTO todoItem);
        TodoItemDTO GetTodoItem(Guid guid);
        TodoItemDTO DeleteTodoItem(Guid guid);
        TodoItemDTO AddTodoItem(AddTodoItemDTO todoItem);
    }
}

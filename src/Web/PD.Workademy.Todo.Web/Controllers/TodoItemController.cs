using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Interfaces;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class TodoItemController : ApiBaseController
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<ActionResult> GetTodoItemAsync(Guid guid)
        {
            return Ok(_todoItemService.GetTodoItem(guid));
        }

        [HttpGet("/TodoItems")]
        public async Task<ActionResult> GetTodoItemsAsync()
        {
            return Ok(_todoItemService.GetTodoItems());
        }

        [HttpPost]
        public async Task<ActionResult> AddTodoItemAsync([FromBody] AddTodoItemDTO newTodoItem)
        {
            return Ok(_todoItemService.AddTodoItem(newTodoItem));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTodoItemAsync(UpdateTodoItemDTO updatedTodoItem)
        {
            return Ok(_todoItemService.UpdateTodoItem(updatedTodoItem));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTodoItemAsync(Guid guid)
        {
            return Ok(_todoItemService.DeleteTodoItem(guid));
        }
    }
}

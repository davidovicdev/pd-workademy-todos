using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class TodoItemController : ApiBaseController
    {
        private readonly List<string> _todoItems = new() { "Clean your room !", "Shut down PC !", "Restart PC !", "Add HTML and CSS !"};
        [HttpGet("/api/TodoItem/{id}")]
        public async Task<ActionResult> GetTodoItemAsync(Guid id)
        {
            return id != Guid.Empty ? Ok(_todoItems[3]) : Ok("It's not GUID"); 
         }
    }
}

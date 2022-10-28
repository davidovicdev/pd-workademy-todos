using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class TodoItemsController : ApiBaseController
    {
        private readonly List<string> todoItems = new() { "Todo Item 1", "Todo Item 2", "Todo Item 3" };
        [HttpGet("/api/[controller]")]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            return Ok(todoItems);
        }
    }
}

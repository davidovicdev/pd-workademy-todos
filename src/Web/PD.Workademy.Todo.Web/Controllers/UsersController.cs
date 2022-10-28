using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class UsersController : ApiBaseController
    {
        private readonly List<string> _users = new() { "User  1", "user 2", "User 3" };
        [HttpGet("/api/[controller]")]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            return Ok(_users);
        }
     }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class UserController : ApiBaseController
    {
        private readonly string[] _users = new[] { "User  1", "user 2", "User 3" };



        [HttpGet("/api/[controller]/{id}")]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            return Ok(_users);
        }
    }
}

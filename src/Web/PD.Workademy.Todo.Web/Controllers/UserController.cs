using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class UserController : ApiBaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> GetUserAsync(Guid guid)
        {
            return Ok(_userService.GetUser(guid));
        }

        [HttpGet("/Users")]
        public async Task<ActionResult> GetCategoriesAsync()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync([FromBody] AddUpdateUserDTO newUser)
        {
            return Ok(_userService.AddUser(newUser));
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateUserAsync(UserDTO updatedUser)
        {
            return Ok(_userService.UpdateUser(updatedUser));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUserAsync(Guid guid)
        {
            return Ok(_userService.DeleteUser(guid));
        }
    }
}

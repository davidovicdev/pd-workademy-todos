using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class UserController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetUserAsync(Guid guid)
        {
            List<UserDTO> existingUsers =
                new()
                {
                    new UserDTO(
                        new Guid("97df5413-9454-4a56-abbd-c918373bbe3c"),
                        "Matija",
                        "Davidovic"
                    ),
                    new UserDTO(
                        new Guid("d209a3b5-9fb9-4e44-8b8d-f5f6fc502732"),
                        "Nikola",
                        "Djokic"
                    ),
                    new UserDTO(
                        new Guid("146c074a-039b-46ab-8ac4-a7fb4a80ec8e"),
                        "Aleksandar",
                        "Vidakovic"
                    ),
                };

            return Ok(existingUsers.Find(x => x.Id == guid));
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync(UserDTO user)
        {
            List<UserDTO> existingUsers =
                new()
                {
                    new UserDTO(
                        new Guid("97df5413-9454-4a56-abbd-c918373bbe3c"),
                        "Matija",
                        "Davidovic"
                    ),
                    new UserDTO(
                        new Guid("d209a3b5-9fb9-4e44-8b8d-f5f6fc502732"),
                        "Nikola",
                        "Djokic"
                    ),
                    new UserDTO(
                        new Guid("146c074a-039b-46ab-8ac4-a7fb4a80ec8e"),
                        "Aleksandar",
                        "Vidakovic"
                    ),
                };
            existingUsers.Add(user);
            return Ok(existingUsers);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(Guid guid, UserDTO updatedUser)
        {
            List<UserDTO> existingUsers =
                new()
                {
                    new UserDTO(
                        new Guid("97df5413-9454-4a56-abbd-c918373bbe3c"),
                        "Matija",
                        "Davidovic"
                    ),
                    new UserDTO(
                        new Guid("d209a3b5-9fb9-4e44-8b8d-f5f6fc502732"),
                        "Nikola",
                        "Djokic"
                    ),
                    new UserDTO(
                        new Guid("146c074a-039b-46ab-8ac4-a7fb4a80ec8e"),
                        "Aleksandar",
                        "Vidakovic"
                    ),
                };
            UserDTO user = existingUsers.Find(x => x.Id == guid);
            user.Id = updatedUser.Id;
            user.LastName = updatedUser.LastName;
            user.FirstName = updatedUser.FirstName;
            return Ok(user);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUserAsync(Guid guid)
        {
            List<UserDTO> existingUsers =
                new()
                {
                    new UserDTO(
                        new Guid("97df5413-9454-4a56-abbd-c918373bbe3c"),
                        "Matija",
                        "Davidovic"
                    ),
                    new UserDTO(
                        new Guid("d209a3b5-9fb9-4e44-8b8d-f5f6fc502732"),
                        "Nikola",
                        "Djokic"
                    ),
                    new UserDTO(
                        new Guid("146c074a-039b-46ab-8ac4-a7fb4a80ec8e"),
                        "Aleksandar",
                        "Vidakovic"
                    ),
                };
            UserDTO user = existingUsers.Find(x => x.Id == guid);
            existingUsers.Remove(user);
            return Ok(existingUsers);
        }
    }
}

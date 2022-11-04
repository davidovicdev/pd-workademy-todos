using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(Guid guid);
        UserDTO UpdateUser(Guid guid, AddUpdateUserDTO category);
        UserDTO DeleteUser(Guid guid);
        UserDTO AddUser(AddUpdateUserDTO category);
    }
}

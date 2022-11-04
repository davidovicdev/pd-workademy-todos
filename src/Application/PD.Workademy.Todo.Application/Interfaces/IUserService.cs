using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(Guid guid);
        UserDTO UpdateUser(Guid guid, UserDTO category);
        UserDTO DeleteUser(Guid guid);
        UserDTO AddUser(UserDTO category);
    }
}

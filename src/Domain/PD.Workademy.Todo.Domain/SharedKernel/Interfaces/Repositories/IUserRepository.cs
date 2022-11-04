using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(Guid guid);
        User UpdateUser(Guid guid, User user);
        User DeleteUser(Guid guid);
        User AddUser(User user);
    }
}

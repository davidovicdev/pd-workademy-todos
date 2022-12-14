using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO AddUser(AddUpdateUserDTO user)
        {
            Guid guid = Guid.NewGuid();
            _userRepository.AddUser(new User(guid, user.FirstName, user.LastName));
            UserDTO userDTO = new(guid, user.FirstName, user.LastName);
            return userDTO;
        }

        public UserDTO DeleteUser(Guid guid)
        {
            User userToDelete = _userRepository.DeleteUser(guid);
            UserDTO userDTO = new(userToDelete.Id, userToDelete.FirstName, userToDelete.LastName);
            return userDTO;
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var users = _userRepository.GetUsers();
            IEnumerable<UserDTO> usersDTO = users.Select(
                x => new UserDTO(x.Id, x.FirstName, x.LastName)
            );
            return usersDTO;
        }

        public UserDTO GetUser(Guid guid)
        {
            User user = _userRepository.GetUser(guid);
            UserDTO userDTO = new(user.Id, user.FirstName, user.LastName);
            return userDTO;
        }

        public UserDTO UpdateUser(UserDTO updatedUser)
        {
            User userToUpdate = new(updatedUser.Id, updatedUser.FirstName, updatedUser.LastName);
            _userRepository.UpdateUser(userToUpdate);
            return updatedUser;
        }
    }
}

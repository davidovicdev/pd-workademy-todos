using PD.Workademy.Todo.Web.ApiModels;
using System.ComponentModel;

namespace PD.Workademy.Todo.Web.Services
{
    public class UsersService : RootService
    {
        public List<UserDTO> GetAllUsers()
        {
            try
            {
                return users;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<UserDTO> GetUsers()
        {
            return users;
        }

        public UserDTO GetUser(Guid guid, List<UserDTO> users)
        {
            try
            {
                return users.Find(x => x.Id == guid);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public UserDTO AddUser(UserDTO user)
        {
            try
            {
                users.Add(user);
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public UserDTO DeleteUser(Guid guid)
        {
            try
            {
                var user = users.Find(x => x.Id == guid);
                users.Remove(user);
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public UserDTO UpdateUser(Guid guid, UserDTO updatedUser)
        {
            try
            {
                UserDTO user = users.Find(x => x.Id == guid);
                user.Id = updatedUser.Id;
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

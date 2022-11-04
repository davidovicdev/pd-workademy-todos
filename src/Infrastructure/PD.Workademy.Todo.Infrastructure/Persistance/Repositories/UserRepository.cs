using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(Guid guid)
        {
            try
            {
                User userToDelete = _dbContext.Users.FirstOrDefault(x => x.Id == guid);
                _dbContext.Users.Remove(userToDelete);
                _dbContext.SaveChanges();
                return userToDelete;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users;
        }

        public User GetUser(Guid guid)
        {
            User? user = _dbContext.Users.FirstOrDefault(x => x.Id == guid);
            return user;
        }

        public User UpdateUser(Guid guid, User updatedUser)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == guid);
            user.Id = updatedUser.Id;
            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            _dbContext.SaveChanges();
            return updatedUser;
        }
    }
}

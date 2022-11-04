using PD.Workademy.Todo.Domain.SharedKernel;
using System.ComponentModel.DataAnnotations;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }

        public User() { }

        public User(Guid guid, string firstName, string lastName)
        {
            Id = guid;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

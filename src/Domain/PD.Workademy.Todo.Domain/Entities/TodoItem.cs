using PD.Workademy.Todo.Domain.SharedKernel;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; private set; }
        public Category Category { get; set; }
        public User User { get; set; }

        public TodoItem() { }

        public TodoItem(
            Guid guid,
            string title,
            bool isDone,
            Category catgory,
            User user,
            string description = ""
        )
        {
            Id = guid;
            Title = title;
            IsDone = isDone;
            Category = catgory;
            User = user;
            Description = description;
        }

        public void ChangeStatus(bool isDone)
        {
            IsDone = isDone;
        }
    }
}

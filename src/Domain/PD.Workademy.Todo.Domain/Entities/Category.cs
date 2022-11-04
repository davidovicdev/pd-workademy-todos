using PD.Workademy.Todo.Domain.SharedKernel;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }

        public Category() { }

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

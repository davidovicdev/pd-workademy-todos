namespace PD.Workademy.Todo.Web.ApiModels
{
    public class TodoItemDTO
    {
        public TodoItemDTO(
            Guid id,
            string title,
            string? description,
            bool isDone,
            CategoryDTO category,
            UserDTO user
        )
        {
            Id = id;
            Title = title;
            Description = description;
            IsDone = isDone;
            Category = category;
            User = user;
        }

        public TodoItemDTO() { }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; private set; }
        public CategoryDTO Category { get; set; }
        public UserDTO User { get; set; }
    }
}

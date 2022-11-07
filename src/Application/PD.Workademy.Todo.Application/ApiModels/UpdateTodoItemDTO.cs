namespace PD.Workademy.Todo.Application.ApiModels
{
    public class UpdateTodoItemDTO
    {
        public UpdateTodoItemDTO(
            Guid id,
            string title,
            string? description,
            bool isDone,
            Guid categoryGuid,
            Guid userGuid
        )
        {
            Id = id;
            Title = title;
            Description = description;
            IsDone = isDone;
            CategoryGuid = categoryGuid;
            UserGuid = userGuid;
        }

        public UpdateTodoItemDTO() { }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public Guid CategoryGuid { get; set; }
        public Guid UserGuid { get; set; }
    }
}

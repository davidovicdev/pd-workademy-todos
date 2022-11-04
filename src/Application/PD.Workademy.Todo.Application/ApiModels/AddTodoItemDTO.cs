using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.ApiModels
{
    public class AddTodoItemDTO
    {
        public AddTodoItemDTO(string title, string? description, Guid categoryGuid, Guid userGuid)
        {
            Title = title;
            Description = description;
            CategoryGuid = categoryGuid;
            UserGuid = userGuid;
        }

        public AddTodoItemDTO() { }

        public string Title { get; set; }
        public string? Description { get; set; }
        public Guid CategoryGuid { get; set; }
        public Guid UserGuid { get; set; }
    }
}

namespace PD.Workademy.Todo.Web.ApiModels
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public CategoryDTO() { }

        public CategoryDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

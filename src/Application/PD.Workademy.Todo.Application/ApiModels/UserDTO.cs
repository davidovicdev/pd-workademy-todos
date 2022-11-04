namespace PD.Workademy.Todo.Web.ApiModels
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserDTO() { }

        public UserDTO(Guid id, string fname, string lname)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
        }
    }
}

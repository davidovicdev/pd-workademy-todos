using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Services
{
    public class RootService
    {
        protected List<UserDTO> users =
            new()
            {
                new UserDTO(
                    new Guid("0ec88728-e085-4248-b840-70c52f855e83"),
                    "Matija",
                    "Davidovic"
                ),
                new UserDTO(
                    new Guid("c196e9f0-00be-409d-bcb4-51fe06e8a45d"),
                    "Aleksandar",
                    "Vidakovic"
                ),
                new UserDTO(new Guid("5844afb7-2b08-4577-9c00-4c19c13e674f"), "Nikola", "Djokic"),
                new UserDTO(new Guid("a6799c5b-317e-424e-82d4-d20010d97a95"), "Goran", "Tesla"),
                new UserDTO(new Guid("54b98ecf-ded5-4ccc-82d7-ad9e342fc78e"), "Srdjan", "Skorkovic")
            };
    }
}

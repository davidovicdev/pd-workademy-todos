using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class TodoItemsController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetTodoItemsAsync()
        {
            List<TodoItemDTO> existingTodoItems =
                new()
                {
                    new TodoItemDTO(
                        new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"),
                        "Create MSSQL Database",
                        "It's not that hard as you think it is !",
                        false,
                        new CategoryDTO(new Guid("2ffa716e-3bd7-4506-89bd-ce317a683284"), "Easy"),
                        new UserDTO(
                            new Guid("7799f7a9-94ed-4ea2-8e6e-a54de860c36d"),
                            "Aleksandar",
                            "Vidakovic"
                        )
                    ),
                    new TodoItemDTO(
                        new Guid("c2458a4e-a7a9-49dd-a9b6-f10a4ca2e32a"),
                        "Add HTML and CSS",
                        "",
                        true,
                        new CategoryDTO(new Guid("dbed6025-d3ed-4a67-938f-2c901b375eda"), "Medium"),
                        new UserDTO(
                            new Guid("19cbb01d-4cf0-4ac3-973a-73b0b733fc0b"),
                            "Nikola",
                            "Djurovic"
                        )
                    ),
                    new TodoItemDTO(
                        new Guid("f9f3587d-9c6c-4779-9989-d417aace856a"),
                        "Learn Entity Framework",
                        "One of the greatest tasks ever!",
                        false,
                        new CategoryDTO(new Guid("55f82203-137f-486f-8feb-5468ff8557d1"), "Hard"),
                        new UserDTO(
                            new Guid("31186090-8d46-44e3-ba0f-d076fa7bd1b1"),
                            "Nikola",
                            "Djokic"
                        )
                    )
                };
            return Ok(existingTodoItems);
        }
    }
}

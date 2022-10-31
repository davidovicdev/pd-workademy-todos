using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class TodoItemController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetTodoItemAsync(Guid guid)
        {
            TodoItemDTO todoItem =
                new(
                    guid,
                    "Learn .NET",
                    "U should learn this as soon as you can !",
                    false,
                    new CategoryDTO(new Guid("928f52a5-7517-4e67-8f08-a96a61e692ed"), "Easy"),
                    new UserDTO(
                        new Guid("205d51ef-3d82-4869-8842-e342e78e78db"),
                        "Matija",
                        "Davidovic"
                    )
                );
            return Ok(todoItem);
        }

        [HttpPost]
        public async Task<ActionResult> AddTodoItemAsync([FromBody] TodoItemDTO newTodoItem)
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
            existingTodoItems.Add(newTodoItem);
            return Ok(existingTodoItems);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTodoItemAsync(Guid guid, TodoItemDTO updatedTodoItem)
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
            TodoItemDTO todoItem = existingTodoItems.Find(x => x.Id == guid);
            todoItem.Id = updatedTodoItem.Id;
            todoItem.Title = updatedTodoItem.Title;
            todoItem.Description = updatedTodoItem.Description;
            //todoItem.IsDone = updatedTodoItem.IsDone;
            todoItem.Category = updatedTodoItem.Category;
            todoItem.User = updatedTodoItem.User;
            return Ok(todoItem);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTodoItemAsync(Guid guid)
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
            TodoItemDTO categoryToDelete = existingTodoItems.Find(x => x.Id == guid);
            existingTodoItems.Remove(categoryToDelete);
            return Ok(existingTodoItems);
        }
    }
}

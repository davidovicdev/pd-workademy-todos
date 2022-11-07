using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ITodoItemRepository _todoItemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;

        public TodoItemService(
            ITodoItemRepository todoItemRepository,
            ICategoryRepository categoryRepository,
            IUserRepository userRepository
        )
        {
            _todoItemRepository = todoItemRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }

        public TodoItemDTO UpdateTodoItem(UpdateTodoItemDTO updatedTodoItem)
        {
            Guid guid = updatedTodoItem.Id;
            User user = _userRepository.GetUser(updatedTodoItem.UserGuid);
            Category category = _categoryRepository.GetCategory(updatedTodoItem.CategoryGuid);
            _todoItemRepository.UpdateTodoItem(
                new TodoItem(
                    guid,
                    updatedTodoItem.Title,
                    false,
                    category,
                    user,
                    updatedTodoItem.Description
                )
            );
            CategoryDTO categoryDTO = new(category.Id, category.Name);
            UserDTO userDTO = new(user.Id, user.FirstName, user.LastName);
            TodoItemDTO todoItemDTO =
                new(
                    guid,
                    updatedTodoItem.Title,
                    updatedTodoItem.Description,
                    false,
                    categoryDTO,
                    userDTO
                );
            return todoItemDTO;
        }

        public TodoItemDTO AddTodoItem(AddTodoItemDTO newTodoItem)
        {
            Guid guid = Guid.NewGuid();
            User user = _userRepository.GetUser(newTodoItem.UserGuid);
            Category category = _categoryRepository.GetCategory(newTodoItem.CategoryGuid);
            _todoItemRepository.AddTodoItem(
                new TodoItem(
                    guid,
                    newTodoItem.Title,
                    false,
                    category,
                    user,
                    newTodoItem.Description
                )
            );
            CategoryDTO categoryDTO = new(category.Id, category.Name);
            UserDTO userDTO = new(user.Id, user.FirstName, user.LastName);
            TodoItemDTO todoItemDTO =
                new(guid, newTodoItem.Title, newTodoItem.Description, false, categoryDTO, userDTO);
            return todoItemDTO;
        }

        public IEnumerable<TodoItemDTO> GetTodoItems()
        {
            var todoItems = _todoItemRepository.GetTodoItems();
            IEnumerable<TodoItemDTO> todoItemsDTO = todoItems.Select(
                x =>
                    new TodoItemDTO(
                        x.Id,
                        x.Title,
                        x.Description,
                        x.IsDone,
                        new CategoryDTO(x.Category.Id, x.Category.Name),
                        new UserDTO(x.User.Id, x.User.FirstName, x.User.LastName)
                    )
            );
            ;
            return todoItemsDTO;
        }

        public TodoItemDTO DeleteTodoItem(Guid guid)
        {
            TodoItem todoItemToDelete = _todoItemRepository.DeleteTodoItem(guid);
            TodoItemDTO todoItemDTO =
                new(
                    todoItemToDelete.Id,
                    todoItemToDelete.Title,
                    todoItemToDelete.Description,
                    todoItemToDelete.IsDone,
                    new CategoryDTO(todoItemToDelete.Category.Id, todoItemToDelete.Category.Name),
                    new UserDTO(
                        todoItemToDelete.User.Id,
                        todoItemToDelete.User.FirstName,
                        todoItemToDelete.User.LastName
                    )
                );
            return todoItemDTO;
        }

        public TodoItemDTO GetTodoItem(Guid guid)
        {
            TodoItem todoItem = _todoItemRepository.GetTodoItem(guid);
            TodoItemDTO todoItemDTO =
                new(
                    todoItem.Id,
                    todoItem.Title,
                    todoItem.Description,
                    todoItem.IsDone,
                    new CategoryDTO(todoItem.Category.Id, todoItem.Category.Name),
                    new UserDTO(todoItem.User.Id, todoItem.User.FirstName, todoItem.User.LastName)
                );
            return todoItemDTO;
        }
    }
}

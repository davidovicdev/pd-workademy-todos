namespace PD.Workademy.Todo.Application.ApiModels
{
    public class TodoItemSPSDTO
    {
        public TodoItemSPSDTO() { }

        public TodoItemSPSDTO(string search, int pageNumber, string sortBy)
        {
            Search = search;
            PageNumber = pageNumber;
            SortBy = sortBy;
        }

        public int PageNumber { get; set; } = 1;

        public string? Search { get; set; } = "";
        public string? SortBy { get; set; }
    }
}

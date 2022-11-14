namespace PD.Workademy.Todo.Application.ApiModels
{
    public class TodoItemSPSDTO
    {
        public TodoItemSPSDTO() { }

        public TodoItemSPSDTO(string search, string sortBy, int page, int perPage)
        {
            Search = search;
            SortBy = sortBy;
            Page = page;
            PerPage = perPage;
        }

        public int PerPage { get; set; }
        public int Page { get; set; }
        public string? Search { get; set; }
        public string? SortBy { get; set; }
    }
}

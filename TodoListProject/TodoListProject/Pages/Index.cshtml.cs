using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoListProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Todo> todoList = new List<Todo>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                var t = new Todo((i % 2 == 0), DateTime.Now, $"This is task number {i}");
                todoList.Add(t);
            }
        }

    }

    public class Todo
    {
        public bool done { get; set; }
        public DateTime dueDate { get; set; }
        public string? description { get; set; }

        public Todo(bool done, DateTime dueDate, string? description)
        {
            this.done = done;
            this.dueDate = dueDate;
            this.description = description;
        }
    }
}
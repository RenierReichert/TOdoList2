using Microsoft.AspNetCore.Mvc;

namespace TodoListProject.Entities
{
    public class Todo
    {

        public int id { get; set; }
        [BindProperty]
        public bool done { get; set; } = false;
        public DateTime dueDate { get; set; } = DateTime.Now;
        [BindProperty]
        public string? description { get; set; }


        public TodoTypeEntity? todoType { get; set; }

        public Todo()
        {
        }

        public Todo(bool done, DateTime dueDate, string description)
        {
            this.done = done;
            this.dueDate = dueDate;
            this.description = description;
        }
    }
}

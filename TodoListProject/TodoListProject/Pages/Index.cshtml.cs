using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TodoListProject.Repo;

namespace TodoListProject.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<Todo> todoList { get; set; }
        public static Todo NewTodo { get; set; } = new Todo(false, DateTime.Now, "TEEEEEEEEEST");

        private ITodoRepo _itodoRepo;

        public IndexModel(ITodoRepo itodorepo)
        {
            this._itodoRepo = itodorepo;
           // _itodoRepo.AddAsync(new Todo(false, DateTime.Now, "TEST"));
            _ = this.GetList();
        }

        public async Task<IEnumerable<Todo>> GetList()
        {
            todoList = await (_itodoRepo.GetAllAsync());
            return await (Task.FromResult(todoList));
        }        

        public async Task<IActionResult> OnPost()
        {

            if(!ModelState.IsValid)
            {
                todoList = await (_itodoRepo.GetAllAsync());
                return Page();
            }

            await _itodoRepo.AddAsync(NewTodo);
            return RedirectToPage();
        }

    }

    public class Todo
    {
        [BindProperty]
        public bool done { get; set; } = false;
        public DateTime dueDate { get; set; } = DateTime.Now;
        [Required]
        public string? description { get; set; }

        public Todo()
        { }
        
        public Todo(bool done, DateTime dueDate, string description)
        {
            this.done = done;
            this.dueDate = dueDate;
            this.description = description;
        }
    }

}
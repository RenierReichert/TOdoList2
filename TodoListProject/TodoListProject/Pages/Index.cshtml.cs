using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TodoListProject.Entities;
using TodoListProject.Repo;

namespace TodoListProject.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Todo> todoList { get; set; }
        public IEnumerable<TodoTypeEntity>? todoTypes { get; set; }
        public IEnumerable<SelectListItem>? selectList { get; set; }

        [BindProperty]
        public Todo NewTodo { get; set; } = new();

        private ITodoRepo _itodoRepo;
        private ITodoTypeRepo _itodoTypeRepo;


        public IndexModel(ITodoRepo itodorepo, ITodoTypeRepo itodoTypeRepo)
        {
            this._itodoRepo = itodorepo;
            this._itodoTypeRepo = itodoTypeRepo;
            _ = this.GetDataAsync();
            NewTodo.id = todoList.Count() + 1;
            // _itodoRepo.AddAsync(new Todo(false, DateTime.Now, "TEST"));

        }

        public async Task<IEnumerable<Todo>> GetData()
        {
            todoList = await (_itodoRepo.GetAllAsync());
            todoTypes = await (_itodoTypeRepo.GetAll());
            return await (Task.FromResult(todoList));
        }

        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                todoList = await (_itodoRepo.GetAllAsync());
                return Page();
            }



            await _itodoRepo.AddAsync(NewTodo);
            return RedirectToPage();
        }


        private async Task GetDataAsync()
        {
            todoTypes = await this._itodoTypeRepo.GetAll();
            todoList = await this._itodoRepo.GetAllAsync();

            selectList = todoTypes.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });

        }
    }
}
using Microsoft.EntityFrameworkCore;
using TodoListProject.DataAccess;
using TodoListProject.Pages;
using TodoListProject.Repo;
using TodoListProject.Entities;

namespace TodoListProject.Repo
{
    public class TodoRepo : ITodoRepo
    {

        private TodoContext _context;

        public TodoRepo(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            return await _context.todoList.ToListAsync();
        }

        public async Task<Todo> AddAsync(Todo todo)
        {
           // todo.id = _context.todoList.Count();
            await _context.todoList.AddAsync(todo);
            _context.SaveChanges();
            return await (Task.FromResult(todo));
        }

    }

}

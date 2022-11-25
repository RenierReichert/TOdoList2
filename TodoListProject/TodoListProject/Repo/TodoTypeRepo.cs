using Microsoft.EntityFrameworkCore;
using TodoListProject.DataAccess;
using TodoListProject.Entities;

namespace TodoListProject.Repo
{
    public class TodoTypeRepo : ITodoTypeRepo
    {
        private TodoContext _context;
        public TodoTypeRepo(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoTypeEntity>> GetAll()
        {
            return await _context.todoTypeEntities.ToListAsync();
        }
    }
}

using TodoListProject.Pages;
using TodoListProject.Entities;

namespace TodoListProject.Repo
{
    public interface ITodoRepo
    {

        Task<Todo> AddAsync(Todo newtodo);

        Task<IEnumerable<Todo>> GetAllAsync();
        
    }
}

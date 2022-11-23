using TodoListProject.Pages;

namespace TodoListProject.Repo
{
    public interface ITodoRepo
    {

        Task<Todo> AddAsync(Todo newtodo);

        Task<IEnumerable<Todo>> GetAllAsync();
        
    }
}

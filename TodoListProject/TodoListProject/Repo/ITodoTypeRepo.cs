using TodoListProject.Entities;

namespace TodoListProject.Repo
{
    public interface ITodoTypeRepo
    {
        Task<IEnumerable<TodoTypeEntity>> GetAll();
    }
}

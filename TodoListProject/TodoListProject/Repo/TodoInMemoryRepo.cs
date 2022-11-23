using TodoListProject.Pages;
using TodoListProject.Repo;

namespace TodoListProject.Repo
{
    public class TodoInMemoryRepo : ITodoRepo
    {
        private static List<Todo> todoList = new();

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            return await Task.FromResult(todoList.AsEnumerable());
        }

        public async Task<Todo> AddAsync(Todo todo)
        {
            todoList.Add(todo);
            return await (Task.FromResult(todo));
        }

    }

}

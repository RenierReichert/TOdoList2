using Microsoft.EntityFrameworkCore;
using TodoListProject.Entities;
using TodoListProject.Pages;

namespace TodoListProject.DataAccess
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> todoList { get; set; }

        public DbSet<TodoTypeEntity> todoTypeEntities { get; set; }
        public TodoContext(DbContextOptions options) : base(options) 
        {
        }
    }
}

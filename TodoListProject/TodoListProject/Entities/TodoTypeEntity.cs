using System.Text.Json.Serialization;
using TodoListProject.Pages;

namespace TodoListProject.Entities
{
    public class TodoTypeEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<Todo> todosWithThisType { get; set; }



    }
}

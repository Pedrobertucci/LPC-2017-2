namespace TodoList.WebApi.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
namespace TodoAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsComplete { get; set; }
        public Todo()
        {

        }
        public Todo(int id, string name, string content, bool isComplete)
        {
            Id = id;
            Name = name;
            Content = content;
            IsComplete = isComplete;
        }


    }
}

using TodoAPI.Models;

namespace TodoAPI.Service
{
    public class TodoService
    {
        private List<Todo> TodoList { get; set; }
        public TodoService(){
            TodoList = new List<Todo>();
               //{
               //    new Todo(1, "hoc bai", "angular", true),
               //    new Todo(2, "hoc bai", "dotnet core", true),
               //    new Todo(3, "hoc bai", "nihongo", true),
               //    new Todo(4, "hoc bai", "AWS", false),
               //    new Todo(5, "lam bai tap", "dotnet", false),
               //};
         }

        public List<Todo> initLst()
        {
            TodoList.Add(new Todo(1, "hoc bai", "angular", true));
            //{
            //    ,
            //    new Todo(2, "hoc bai", "dotnet core", true),
            //    new Todo(3, "hoc bai", "nihongo", true),
            //    new Todo(4, "hoc bai", "AWS", false),
            //    new Todo(5, "lam bai tap", "dotnet", false),
            //};
            return TodoList;
        }
        public List<Todo> GetAll()
        {
            return TodoList;
        }

        public bool AddTodo(Todo todo)
        {
            if(todo == null) return false;
            TodoList.Add(todo);
            return true;
        }

        public Todo FindOne(int id)
        {
            for(int i = 0; i < TodoList.Count; i++)
            {
                if (TodoList[i].Id == id) return TodoList[i];   
            }
            return null!;
        }
        public bool Delete(int id) {

            return TodoList.Remove(FindOne(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TodoAPI.Service;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;
        public TodoController(TodoService todoService) {
            _todoService = todoService;

        }

        [HttpPost("init")]
        public ActionResult initLst()
        {
            return Ok(_todoService.initLst());
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_todoService.GetAll());
        }
        [HttpPost]
        public ActionResult AddTodo(Todo todo) {
            return Ok(_todoService.AddTodo(todo));
        }
        [HttpGet("{id}")]
        public ActionResult FindOne(int id)
        {
            return Ok(_todoService.FindOne(id));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_todoService.Delete(id));
        }
    }
}

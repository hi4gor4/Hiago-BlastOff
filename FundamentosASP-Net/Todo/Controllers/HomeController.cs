using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    [ApiController]//Decorator de controller
    public class HomeController : ControllerBase
    {
        [HttpGet]//Get tambem é o tipo default
        [Route("todo")]//Define a rota a ser usada
        public List<TodoModel> Get([FromServices] AppDbContext  context)
        {
            return context.Todos.ToList();
        }

        [HttpPost]
        [Route("todo")]
        public TodoModel Post(
            [FromBody] TodoModel model,
            [FromServices] AppDbContext  context)
        {
            context.Todos.Add(model);
            context.SaveChanges();
            return model;
        }
    }
}
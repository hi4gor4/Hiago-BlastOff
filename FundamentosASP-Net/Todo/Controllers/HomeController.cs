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
        public IActionResult Get([FromServices] AppDbContext  context)
            => Ok(context.Todos.ToList());
        
        [HttpGet]//Get tambem é o tipo default
        [Route("todo/{id}")]//Define a rota a ser usada
        public IActionResult GetById(
            [FromRoute] int id,
            [FromServices] AppDbContext  context)
        {
            var todo =  context.Todos.FirstOrDefault(x=> x.Id == id);
            if(todo == null)
                return NotFound();
            return Ok(todo);
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

        [HttpPut("/{id:int}")]
        public IActionResult Put(
            [FromRoute] int id,
            [FromBody] TodoModel todo,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return NotFound();

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todos.Update(model);
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("/{id:int}")]
        public IActionResult Delete(
            [FromRoute] int id,
            [FromServices] AppDbContext context)
        {
            var model = context.Todos.FirstOrDefault(x => x.Id == id);
            if (model == null)
                return NotFound();

            context.Todos.Remove(model);
            context.SaveChanges();

            return Ok(model);
        }
        
    }
}
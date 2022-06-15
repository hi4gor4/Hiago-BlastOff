using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [ApiController]//Decorator de controller
    public class HomeController : ControllerBase
    {
        [HttpGet]//Get tambem é o tipo default
        [Route("/init")]//Define a rota a ser usada
        public string Get()
        {
            return "HelloWord";
        }
    }
}
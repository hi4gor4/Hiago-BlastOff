using FunkoApi.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace FunkoApi.Contollers
{
    [ApiController]
    [Route("/home")]
    public class CColecao : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult GetCollection([FromServices]FunkoApiContext context )
        => Ok(context.Colecoes.ToList());

    }
}
using Microsoft.AspNetCore.Mvc;

namespace GestorTributario.API.Controllers
{
    [Route("api/v1/gestor")]
    public class GestorTributarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

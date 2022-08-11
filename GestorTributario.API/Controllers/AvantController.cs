using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models.Avant;
using GestorTributario.API.AppService.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace GestorTributario.API.Controllers
{
    public class AvantController : ApiController
    {
        private IGestorService<AvantTributo> _service { get; set; }

        public AvantController([FromServices] IGestorService<AvantTributo> service)
        {
            _service = service;
        }

        [HttpGet("avant/consultar")]
        public IActionResult Get([FromQuery] ConsultaParametros parametros)
        {
            return Ok(_service.ConsultarTributacaoProduto(parametros));
        }
    }
}

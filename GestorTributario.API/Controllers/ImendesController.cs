using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models.Imendes;
using GestorTributario.API.AppService.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace GestorTributario.API.Controllers
{
    public class ImendesController : ApiController
    {
        private IGestorService<ImendesTributo> _service { get; set; }

        public ImendesController([FromServices] IGestorService<ImendesTributo> service)
        {
            _service = service;
        }

        [HttpGet("imendes/consultar")]
        public IActionResult Get([FromQuery]  ConsultaParametros parametros)
        {
            return Ok(_service.ConsultarTributacaoProduto(parametros));
        }
    }
}

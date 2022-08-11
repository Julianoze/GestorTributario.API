using System.Threading.Tasks;
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
        public async Task<IActionResult> Get([FromQuery]  ConsultaParametros parametros)
        {
            return Ok(await _service.ConsultarTributacaoProduto(parametros));
        }
    }
}

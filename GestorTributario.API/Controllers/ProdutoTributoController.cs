using System.Threading.Tasks;
using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models.Avant;
using GestorTributario.API.AppService.Models.Imendes;
using GestorTributario.API.AppService.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace GestorTributario.API.Controllers
{
    public class ProdutoTributoController : ApiController
    {
        private IProdutoTributoAppService<AvantTributo> _avantService { get; set; }
        private IProdutoTributoAppService<ImendesTributo> _imendesService { get; set; }

        public ProdutoTributoController([FromServices]
                                         IProdutoTributoAppService<AvantTributo> avantService,
                                         IProdutoTributoAppService<ImendesTributo> imendesService)
        {
            _avantService = avantService;
            _imendesService = imendesService;
        }

        [HttpGet("produto/converter/avant")]
        public async Task<IActionResult> ConverterAvant([FromQuery] ConsultaParametros parametros)
        {
            return Ok(await _avantService.ConsultarTributacaoProduto(parametros));
        }

        [HttpGet("produto/converter/imendes")]
        public async Task<IActionResult> ConverterImendes([FromQuery] ConsultaParametros parametros)
        {
            return Ok(await _imendesService.ConsultarTributacaoProduto(parametros));
        }
    }
}

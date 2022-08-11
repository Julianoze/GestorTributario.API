﻿using System.Threading.Tasks;
using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace GestorTributario.API.Controllers
{
    public class ProdutoTributoController : ApiController
    {
        private IGestorService<ProdutoTributo> _service { get; set; }

        public ProdutoTributoController([FromServices] IGestorService<ProdutoTributo> service)
        {
            _service = service;
        }

        [HttpGet("produto/consultar")]
        public async Task<IActionResult> Get([FromQuery] ConsultaParametros parametros)
        {
            return Ok(await _service.ConsultarTributacaoProduto(parametros));
        }
    }
}

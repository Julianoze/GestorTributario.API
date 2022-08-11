using System;
using System.Net.Http;
using System.Threading.Tasks;
using GestorTributario.API.AppService.Models.Avant;
using GestorTributario.API.AppService.Models.Parameters;
using GestorTributario.API.Infra.Service.Abstract;

namespace GestorTributario.API.Infra.Service
{
    public class AvantService : ServiceBase<AvantTributo>
    {
        public AvantService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async override Task<AvantTributo> ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            var uri = new Uri($"{Environment.GetEnvironmentVariable("AVANT_API")}/api/v1/products?id={parametros.CodigoProduto}");
            return await GetAsync(uri);
        }
    }
}
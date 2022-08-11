using System;
using System.Net.Http;
using System.Threading.Tasks;
using GestorTributario.API.AppService.Models.Imendes;
using GestorTributario.API.AppService.Models.Parameters;
using GestorTributario.API.Infra.Service.Abstract;

namespace GestorTributario.API.Infra.Service
{
    public class ImendesService : ServiceBase<ImendesTributo>
    {
        public ImendesService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async override Task<ImendesTributo> ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            var uri = new Uri($"{Environment.GetEnvironmentVariable("IMENDES_API")}/api/v1/produtos?id={parametros.CodigoProduto}");
            return await GetAsync(uri);
        }
    }
}
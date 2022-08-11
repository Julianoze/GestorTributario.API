using System.Net.Http;
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

        public override ImendesTributo ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            System.Console.WriteLine("Consultou Imendes");
            return null;
        }
    }
}
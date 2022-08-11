using System.Net.Http;
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

        public override AvantTributo ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            System.Console.WriteLine("Consultou Avant");
            return null;
        }
    }
}
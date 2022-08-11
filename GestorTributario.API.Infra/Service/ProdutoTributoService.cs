using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.Infra.Service
{
    public class ProdutoTributoService : IGestorService<ProdutoTributo>
    {
        public ProdutoTributo ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            System.Console.WriteLine("Converteu produto");
            return null;

        }
    }
}
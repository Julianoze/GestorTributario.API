using System.Threading.Tasks;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.AppService.Interfaces
{
    public interface IProdutoTributoAppService<T>
    {
       Task<ProdutoTributo> ConsultarTributacaoProduto(ConsultaParametros parametros);
    }
}
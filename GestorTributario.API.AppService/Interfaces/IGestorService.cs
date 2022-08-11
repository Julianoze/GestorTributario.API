using System.Threading.Tasks;
using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.AppService.Interfaces
{
    public interface IGestorService<T>
    {
       Task<T> ConsultarTributacaoProduto(ConsultaParametros parametros);
    }
}
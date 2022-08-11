using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.AppService.Interfaces
{
    public interface IGestorService<T>
    {
        T ConsultarTributacaoProduto(ConsultaParametros parametros);
    }
}
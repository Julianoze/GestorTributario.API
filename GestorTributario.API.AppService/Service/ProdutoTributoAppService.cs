using System.Threading.Tasks;
using AutoMapper;
using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.AppService.Service
{
    public class ProdutoTributoAppService<T> : IProdutoTributoAppService<T>
    {
        private readonly IMapper _mapper;
        private readonly IGestorService<T> _service;

        public ProdutoTributoAppService(IMapper mapper, IGestorService<T> service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<ProdutoTributo> ConsultarTributacaoProduto(ConsultaParametros parametros)
        {
            return _mapper.Map<ProdutoTributo>(await _service.ConsultarTributacaoProduto(parametros));
        }
    }
}
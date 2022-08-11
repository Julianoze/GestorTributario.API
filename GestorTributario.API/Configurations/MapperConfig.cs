using AutoMapper;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Avant;
using GestorTributario.API.AppService.Models.Imendes;

namespace GestorTributario.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            AddMappers();
        }
        private void AddMappers()
        {
            CreateMap<ImendesTributo, ProdutoTributo>();

            CreateMap<AvantTributo, ProdutoTributo>()
                .ForMember(produto => produto.Descricao, avant => avant.MapFrom(x => x.Descricao.Descricao))
                .ForMember(produto => produto.CST, avant => avant.MapFrom(x => x.ICMSTributo.CST))
                .ForMember(produto => produto.ICMS, avant => avant.MapFrom(x => x.ICMSTributo.ICMS));

        }
    }
}
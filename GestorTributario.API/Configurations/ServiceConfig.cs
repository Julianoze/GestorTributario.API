using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models;
using GestorTributario.API.AppService.Models.Avant;
using GestorTributario.API.AppService.Models.Imendes;
using GestorTributario.API.Infra.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GestorTributario.API.Configurations.AutoMapperConfig
{
    public static class ServiceConfig
    {
        public static void AutoMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IGestorService<AvantTributo>, AvantService>();
            services.AddScoped<IGestorService<ImendesTributo>, ImendesService>();
            services.AddScoped<IGestorService<ProdutoTributo>, ProdutoTributoService>();
        }
    }
}
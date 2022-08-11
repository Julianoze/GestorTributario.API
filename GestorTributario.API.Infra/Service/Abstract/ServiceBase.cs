using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GestorTributario.API.AppService.Interfaces;
using GestorTributario.API.AppService.Models.Parameters;

namespace GestorTributario.API.Infra.Service.Abstract
{
    public abstract class ServiceBase<T> : IGestorService<T>
    {
        protected readonly HttpClient _httpClient;

        protected ServiceBase(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("HttpClientWithSSLUntrusted");
        }

        protected async Task<T> GetAsync(Uri uri)
        {
            var response = await _httpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(content);
        }

        public abstract Task<T> ConsultarTributacaoProduto(ConsultaParametros parametros);
    }
}
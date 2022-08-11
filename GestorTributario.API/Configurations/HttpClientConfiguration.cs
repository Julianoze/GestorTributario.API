using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GestorTributario.API.Configurations
{
    public static class HttpClientConfiguration
    {
        public static void AddHttpClientConfiguration(this IServiceCollection services)
        {
            services.AddHttpClient("HttpClientWithSSLUntrusted")
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    ClientCertificateOptions = ClientCertificateOption.Manual,
                    ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    }
                });
        }
    }
}
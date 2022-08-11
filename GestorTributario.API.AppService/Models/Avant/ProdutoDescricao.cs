using System.Text.Json.Serialization;

namespace GestorTributario.API.AppService.Models.Avant
{
    public class ProdutoDescricao
    {
        [JsonPropertyName("name")]
        public string Descricao { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace GestorTributario.API.AppService.Models.Avant
{
    public class AvantTributo
    {
        [JsonPropertyName("detail")]
        public ProdutoDescricao Descricao { get; set; }

        [JsonPropertyName("icms")]
        public ICMSTributo ICMSTributo { get; set; }
    }
}
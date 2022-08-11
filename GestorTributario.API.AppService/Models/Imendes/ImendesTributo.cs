using System.Text.Json.Serialization;

namespace GestorTributario.API.AppService.Models.Imendes
{
    public class ImendesTributo
    {
        [JsonPropertyName("nome")]
        public string Descricao { get; set; }

        [JsonPropertyName("icms")]
        public decimal ICMS { get; set; }

        [JsonPropertyName("cst")]
        public string CST { get; set; }
    }
}
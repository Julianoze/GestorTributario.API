using System.Text.Json.Serialization;

namespace GestorTributario.API.AppService.Models.Avant
{
    public class ICMSTributo
    {
        [JsonPropertyName("aliq")]
        public decimal ICMS { get; set; }

        [JsonPropertyName("cst")]
        public string CST { get; set; }
    }
}
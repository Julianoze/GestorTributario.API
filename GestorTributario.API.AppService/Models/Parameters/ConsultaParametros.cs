using System.ComponentModel.DataAnnotations;

namespace GestorTributario.API.AppService.Models.Parameters
{
    public class ConsultaParametros
    {
        [Required]
        public int CodigoProduto { get; set; }
    }
}
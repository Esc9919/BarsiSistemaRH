using System.ComponentModel.DataAnnotations.Schema;

namespace Barsi.Api.Models.Dtos.PontoDtos
{
    public class AdicionarUsuarioPontoDto
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        [ForeignKey("idFuncionario")]
        public long idFuncionario { get; set; } // Chave estrangeira
    }
}

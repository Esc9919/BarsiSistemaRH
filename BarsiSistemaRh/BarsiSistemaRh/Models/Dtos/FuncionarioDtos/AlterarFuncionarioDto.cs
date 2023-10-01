using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Barsi.Api.Models.Dtos.FuncionarioDtos;

public class AlterarFuncionarioDto
{
    public string telefone { get; set; }
    public string email { get; set; }
    public string usuario { get; set; }
    public string senha { get; set; }

}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barsi.Api.Models;

public class Ponto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 idPonto { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }
    public DateTime? pontoEntrada { get; set; }
    public DateTime? pontoAlmocoSaida { get; set; }
    public DateTime? pontoAlmocoVolta { get; set; }
    public DateTime? pontoSaida { get; set; }
    public DateTime? pontoExtra1 { get; set; }
    public DateTime? pontoExtra2 { get; set; }
    [ForeignKey("idFuncionario")]
    public Int64 idFuncionario { get; set; } // Chave estrangeira
    public virtual Funcionario Funcionario { get; set; }

}

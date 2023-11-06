using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barsi.Api.Models;

public class Ponto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 idPonto { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoEntrada { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoAlmocoSaida { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoAlmocoVolta { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoSaida { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoExtra1 { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? pontoExtra2 { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan? HorasTrabalhadas { get; set; }
    [ForeignKey("idFuncionario")]
    public Int64 idFuncionario { get; set; }
    public virtual Funcionario? Funcionario { get; set; }

}

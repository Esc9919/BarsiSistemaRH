using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Barsi.Api.Models;

namespace BarsiSistemaRh.Models;

public class Funcionario
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 idFuncionario { get; set; }
    [Required(ErrorMessage = "O nome do funionário é obrigatorio!")]
    public string nome { get; set; }
    [Required(ErrorMessage = "O CPF do funionário é obrigatorio!")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF tem que ter 11 dígitos!")]
    public string cpf { get; set; }
    [Required(ErrorMessage = "O RG do funionário é obrigatorio!")]
    public string rg { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime dataNascimento { get; set; }
    public string nacionalidade { get; set; }
    public string telefone { get; set; }
    public string email { get; set; }
    public string usuario { get; set; }
    public string senha { get; set; }
    public string logradouro { get; set; }
    public string numero { get; set; }
    public string complemento { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    public string cep { get; set; }
    public double salario { get; set; }
    public string nomeBanco { get; set; }
    public int codigoBanco { get; set; }
    public int agenciaBancaria { get; set; }
    public int contaBancaria { get; set; }
    public int diasTrabalhados { get; set; }
    public int diasHomeOffice { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan? horasExtras { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? inicioFerias { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? fimFerias { get; set; }
    public double fgts { get; set; }
    public double inss { get; set; }
    public double irrs { get; set; }
    public double valeTransporte { get; set; }
    public double valeAlimentacao { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime dataAdmissao { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? dataDemissao { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan? cargaHoraria { get; set; }
    public Cargo cargo { get; set; }

    [ForeignKey("idDepartamento")]
    public Int64 idDepartamento { get; set; } // Chave estrangeira
    public Departamento? departamento { get; set; } // Propriedade de navegação
    public ICollection<Ponto> Pontos { get; set; } // Uma coleção de pontos para o funcionário
}

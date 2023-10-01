using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Barsi.Api.Models.Dtos.FuncionarioDtos;

public class AdicionarFuncionarioDto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long idFuncionario { get; set; }
    [Required(ErrorMessage = "O nome do funionário é obrigatorio!")]
    public string nome { get; set; }
    [Required(ErrorMessage = "O CPF do funionário é obrigatorio!")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF tem que ter 11 dígitos!")]
    public string cpf { get; set; }
    public string rg { get; set; }
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
    public TimeSpan horasExtras { get; set; }
    public double fgts { get; set; }
    public double inss { get; set; }
    public double irrs { get; set; }
    public double valeTransporte { get; set; }
    public double valeAlimentacao { get; set; }
    public DateTime dataAdmissao { get; set; }
    public DateTime? dataDemissao { get; set; }
    public TimeSpan cargaHoraria { get; set; }
    public Cargo cargo { get; set; }

    [ForeignKey("idDepartamento")]
    public long idDepartamento { get; set; } // Chave estrangeira
    public Departamento? departamento { get; set; } // Propriedade de navegação
}

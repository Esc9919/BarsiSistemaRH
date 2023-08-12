namespace BarsiSistemaRH.Models
{
    public class Funcionario
    {
        public Int32 idFuncionario { get; set; }
        public string nome { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private DateOnly dataNascimento { get; set; }
        private string nacionalidade { get; set; }
        private string telefone { get; set; }
        private string email { get; set; }
        private string usuario { get; set; }
        private string senha { get; set; }
        private Cargo cargo { get; set; }
        private Departamento departamento { get; set; }
        private string logradouro { get; set; }
        private string numero { get; set; }
        private string complemento { get; set; }
        private string cidade { get; set; }
        private string uf { get; set; }
        private string cep { get; set; }
        private double salario { get; set; }
        private string nomeBanco { get; set; }
        private int agenciaBancaria { get; set; }
        private int contaBancaria { get; set; }
        private int diasTrabalhados { get; set; }
        private int diasHomeOffice { get; set; }
        private TimeOnly horasExtras { get; set; }
        private double fgts { get; set; }
        private double inss { get; set; }
        private double irrs { get; set; }
        private double valeTransporte { get; set; }
        private double valeAlimentacao { get; set; }
        private DateOnly dataAdmissao { get; set; }
        private DateOnly dataDemissao { get; set; }
        private TimeOnly cargaHoraria { get; set; }



    }

}

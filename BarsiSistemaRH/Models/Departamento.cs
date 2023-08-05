namespace BarsiSistemaRH.Models
{
    public class Departamento
    {
        private int idDepartamento { get; set; }
        private string nomeDepartamento { get; set; }
        private DateOnly dataCriacao { get; set; }
        private Funcionario Responsavel { get; set; }
    }

}

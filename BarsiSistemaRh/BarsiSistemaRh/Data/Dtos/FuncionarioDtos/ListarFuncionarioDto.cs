﻿namespace BarsiSistemaRh.Data.Dtos.FuncionarioDtos;

public class ListarFuncionarioDto
{
    public string nome { get; set; }
    public string cpf { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public string usuario { get; set; }
    public DateTime horaConsulta { get; set; } = DateTime.Now;
}

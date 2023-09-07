﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarsiSistemaRh.Models;

public class Departamento
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 idDepartamento { get; set; }
    public string? nomeDepartamento { get; set; }
    public DateTime criacaoDepartamento { get; set; }
    public List<Funcionario>? funcionarios { get; set; } // Propriedade de navegação para a lista de Funcionarios
}
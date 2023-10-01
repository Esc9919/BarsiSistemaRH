using Barsi.Api.Models;
using BarsiSistemaRh.Models;
using Microsoft.EntityFrameworkCore;

namespace BarsiSistemaRh.Data;

public class FuncionarioContext : DbContext
{

    public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;");

    }

    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Ponto> Pontos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.departamento)
            .WithMany(d => d.funcionarios)
            .HasForeignKey(f => f.idDepartamento); // Usando DepartamentoId como chave estrangeira

        modelBuilder.Entity<Departamento>()
            .HasMany(d => d.funcionarios) // Departamento tem muitos Funcionarios
            .WithOne(f => f.departamento) // Funcionario pertence a um Departamento
            .HasForeignKey(f => f.idDepartamento); // Usando DepartamentoId como chave estrangeira

        modelBuilder.Entity<Ponto>()
            .HasOne(p => p.Funcionario) // Um ponto pertence a um funcionário
            .WithMany(f => f.Pontos) // Um funcionário pode ter muitos pontos
            .HasForeignKey(p => p.idFuncionario); // Chave estrangeira usando o CPF
    }


}

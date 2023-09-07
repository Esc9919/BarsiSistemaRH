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
    }




}

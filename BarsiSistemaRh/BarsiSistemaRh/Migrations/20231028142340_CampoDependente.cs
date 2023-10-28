using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarsiSistemaRh.Migrations
{
    /// <inheritdoc />
    public partial class CampoDependente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Pontos");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HorasTrabalhadas",
                table: "Pontos",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "dependentes",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasTrabalhadas",
                table: "Pontos");

            migrationBuilder.DropColumn(
                name: "dependentes",
                table: "Funcionarios");

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Pontos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarsiSistemaRh.Migrations
{
    /// <inheritdoc />
    public partial class removendoCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cargaHoraria",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "inss",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "irrs",
                table: "Funcionarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "cargaHoraria",
                table: "Funcionarios",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "inss",
                table: "Funcionarios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "irrs",
                table: "Funcionarios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

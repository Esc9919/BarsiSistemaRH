using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarsiSistemaRh.Migrations
{
    /// <inheritdoc />
    public partial class Ponto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Departamento_idDepartamento",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "idDepartamento");

            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    idPonto = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pontoEntrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pontoAlmocoSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pontoAlmocoVolta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pontoSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pontoExtra1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pontoExtra2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    idFuncionario = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontos", x => x.idPonto);
                    table.ForeignKey(
                        name: "FK_Pontos_Funcionarios_idFuncionario",
                        column: x => x.idFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "idFuncionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontos_idFuncionario",
                table: "Pontos",
                column: "idFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Departamentos_idDepartamento",
                table: "Funcionarios",
                column: "idDepartamento",
                principalTable: "Departamentos",
                principalColumn: "idDepartamento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Departamentos_idDepartamento",
                table: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Pontos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "idDepartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Departamento_idDepartamento",
                table: "Funcionarios",
                column: "idDepartamento",
                principalTable: "Departamento",
                principalColumn: "idDepartamento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barsi.Api.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    idDepartamento = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    criacaoDepartamento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.idDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    idFuncionario = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    rg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dependentes = table.Column<int>(type: "int", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salario = table.Column<double>(type: "float", nullable: false),
                    nomeBanco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoBanco = table.Column<int>(type: "int", nullable: false),
                    agenciaBancaria = table.Column<int>(type: "int", nullable: false),
                    contaBancaria = table.Column<int>(type: "int", nullable: false),
                    diasTrabalhados = table.Column<int>(type: "int", nullable: false),
                    diasHomeOffice = table.Column<int>(type: "int", nullable: false),
                    horasExtras = table.Column<TimeSpan>(type: "time", nullable: true),
                    inicioFerias = table.Column<DateTime>(type: "datetime", nullable: true),
                    fimFerias = table.Column<DateTime>(type: "datetime", nullable: true),
                    fgts = table.Column<double>(type: "float", nullable: false),
                    valeTransporte = table.Column<double>(type: "float", nullable: false),
                    valeAlimentacao = table.Column<double>(type: "float", nullable: false),
                    dataAdmissao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataDemissao = table.Column<DateTime>(type: "datetime", nullable: true),
                    cargo = table.Column<int>(type: "int", nullable: false),
                    idDepartamento = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.idFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Departamentos_idDepartamento",
                        column: x => x.idDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "idDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    idPonto = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pontoEntrada = table.Column<DateTime>(type: "datetime", nullable: true),
                    pontoAlmocoSaida = table.Column<DateTime>(type: "datetime", nullable: true),
                    pontoAlmocoVolta = table.Column<DateTime>(type: "datetime", nullable: true),
                    pontoSaida = table.Column<DateTime>(type: "datetime", nullable: true),
                    pontoExtra1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    pontoExtra2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    HorasTrabalhadas = table.Column<TimeSpan>(type: "time", nullable: true),
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
                name: "IX_Funcionarios_idDepartamento",
                table: "Funcionarios",
                column: "idDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Pontos_idFuncionario",
                table: "Pontos",
                column: "idFuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pontos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarsiSistemaRh.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaodoponto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nome",
                table: "Pontos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Pontos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

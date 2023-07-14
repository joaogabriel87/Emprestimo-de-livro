using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emprestimo_de_livro.Migrations
{
    /// <inheritdoc />
    public partial class AttBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LivroEmprestado",
                table: "Emprestimo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LivroEmprestado",
                table: "Emprestimo");
        }
    }
}

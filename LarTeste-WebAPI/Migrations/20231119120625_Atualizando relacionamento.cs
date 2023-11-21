using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LarTeste_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Atualizandorelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                unique: true);
        }
    }
}

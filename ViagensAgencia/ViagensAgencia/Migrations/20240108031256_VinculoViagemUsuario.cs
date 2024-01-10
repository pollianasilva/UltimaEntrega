using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViagensAgencia.Migrations
{
    /// <inheritdoc />
    public partial class VinculoViagemUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Viagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Viagens_UsuarioId",
                table: "Viagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viagens_Usuarios_UsuarioId",
                table: "Viagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viagens_Usuarios_UsuarioId",
                table: "Viagens");

            migrationBuilder.DropIndex(
                name: "IX_Viagens_UsuarioId",
                table: "Viagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Viagens");
        }
    }
}

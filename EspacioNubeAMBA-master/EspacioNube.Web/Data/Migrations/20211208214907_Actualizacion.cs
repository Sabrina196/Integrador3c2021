using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.Web.Data.Migrations
{
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioID",
                table: "Profesionales",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_UsuarioID",
                table: "Profesionales",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Users_UsuarioID",
                table: "Profesionales",
                column: "UsuarioID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Users_UsuarioID",
                table: "Profesionales");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_UsuarioID",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Profesionales");
        }
    }
}

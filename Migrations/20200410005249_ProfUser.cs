using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAspCore.Migrations
{
    public partial class ProfUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Professeur_code_professeur",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_code_professeur",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "code_professeur",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "code_user",
                table: "Professeur",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nom",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prenom",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professeur_code_user",
                table: "Professeur",
                column: "code_user",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Professeur_AspNetUsers_code_user",
                table: "Professeur",
                column: "code_user",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professeur_AspNetUsers_code_user",
                table: "Professeur");

            migrationBuilder.DropIndex(
                name: "IX_Professeur_code_user",
                table: "Professeur");

            migrationBuilder.DropColumn(
                name: "code_user",
                table: "Professeur");

            migrationBuilder.DropColumn(
                name: "nom",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "prenom",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "status",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "code_professeur",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_code_professeur",
                table: "AspNetUsers",
                column: "code_professeur",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Professeur_code_professeur",
                table: "AspNetUsers",
                column: "code_professeur",
                principalTable: "Professeur",
                principalColumn: "code_professeur",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

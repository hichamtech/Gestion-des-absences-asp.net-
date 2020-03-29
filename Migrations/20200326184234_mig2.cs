using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAspCore.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abscence_Etudiant_etudiantcode_etudiant",
                table: "Abscence");

            migrationBuilder.AlterColumn<int>(
                name: "etudiantcode_etudiant",
                table: "Abscence",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "professeucode_professeur",
                table: "Abscence",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "professeurcode_professeur",
                table: "Abscence",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "seancecode_seance",
                table: "Abscence",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abscence_professeurcode_professeur",
                table: "Abscence",
                column: "professeurcode_professeur");

            migrationBuilder.CreateIndex(
                name: "IX_Abscence_seancecode_seance",
                table: "Abscence",
                column: "seancecode_seance");

            migrationBuilder.AddForeignKey(
                name: "FK_Abscence_Etudiant_etudiantcode_etudiant",
                table: "Abscence",
                column: "etudiantcode_etudiant",
                principalTable: "Etudiant",
                principalColumn: "code_etudiant",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abscence_Professeur_professeurcode_professeur",
                table: "Abscence",
                column: "professeurcode_professeur",
                principalTable: "Professeur",
                principalColumn: "code_professeur",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abscence_Seance_seancecode_seance",
                table: "Abscence",
                column: "seancecode_seance",
                principalTable: "Seance",
                principalColumn: "code_seance",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abscence_Etudiant_etudiantcode_etudiant",
                table: "Abscence");

            migrationBuilder.DropForeignKey(
                name: "FK_Abscence_Professeur_professeurcode_professeur",
                table: "Abscence");

            migrationBuilder.DropForeignKey(
                name: "FK_Abscence_Seance_seancecode_seance",
                table: "Abscence");

            migrationBuilder.DropIndex(
                name: "IX_Abscence_professeurcode_professeur",
                table: "Abscence");

            migrationBuilder.DropIndex(
                name: "IX_Abscence_seancecode_seance",
                table: "Abscence");

            migrationBuilder.DropColumn(
                name: "professeucode_professeur",
                table: "Abscence");

            migrationBuilder.DropColumn(
                name: "professeurcode_professeur",
                table: "Abscence");

            migrationBuilder.DropColumn(
                name: "seancecode_seance",
                table: "Abscence");

            migrationBuilder.AlterColumn<int>(
                name: "etudiantcode_etudiant",
                table: "Abscence",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Abscence_Etudiant_etudiantcode_etudiant",
                table: "Abscence",
                column: "etudiantcode_etudiant",
                principalTable: "Etudiant",
                principalColumn: "code_etudiant",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

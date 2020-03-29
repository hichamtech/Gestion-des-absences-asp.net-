using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAspCore.Migrations
{
    public partial class rfidAttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code_rfid",
                table: "Etudiant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code_rfid",
                table: "Etudiant");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace IkProjemCore3dot1.Migrations
{
    public partial class c6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdi",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciAdi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "User");
        }
    }
}

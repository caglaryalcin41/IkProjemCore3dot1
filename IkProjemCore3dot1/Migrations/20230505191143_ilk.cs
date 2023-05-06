using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IkProjemCore3dot1.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ct_RolePrivilege",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    WebItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ct_RolePrivilege", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ct_UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ct_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unvan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true),
                    Soyadi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true),
                    AreaName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    UpperId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel16",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedName = table.Column<string>(nullable: true),
                    AktifMi = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    EditedOn = table.Column<DateTime>(nullable: true),
                    EditedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    ActiveOn = table.Column<DateTime>(nullable: true),
                    ActivetedBy = table.Column<int>(nullable: true),
                    Reserved1 = table.Column<string>(nullable: true),
                    Reserved2 = table.Column<string>(nullable: true),
                    Ad = table.Column<string>(maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(nullable: true),
                    SirketNumarasi = table.Column<int>(nullable: true),
                    UnvanId = table.Column<int>(nullable: true),
                    IseGirisTarihi = table.Column<DateTime>(nullable: true),
                    CikisTarihi = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel16", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel16_Unvan_UnvanId",
                        column: x => x.UnvanId,
                        principalTable: "Unvan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personel16_UnvanId",
                table: "Personel16",
                column: "UnvanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ct_RolePrivilege");

            migrationBuilder.DropTable(
                name: "ct_UserRole");

            migrationBuilder.DropTable(
                name: "Personel16");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WebItem");

            migrationBuilder.DropTable(
                name: "Unvan");
        }
    }
}

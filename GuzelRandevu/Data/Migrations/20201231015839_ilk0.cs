using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class ilk0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "musteriTelNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uyeAdi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uyeSoyadi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "GuzellikMerkezi",
                columns: table => new
                {
                    merkezId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    merkezAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merkezAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merkezEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merkezResim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuzellikMerkezi", x => x.merkezId);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    uyeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    merkezId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    randevuDegerlendirmesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    randevuPuani = table.Column<int>(type: "int", nullable: false),
                    randevuGunu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    randevuSaati = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => new { x.merkezId, x.uyeId });
                    table.ForeignKey(
                        name: "FK_Randevu_AspNetUsers_uyeId",
                        column: x => x.uyeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevu_GuzellikMerkezi_merkezId",
                        column: x => x.merkezId,
                        principalTable: "GuzellikMerkezi",
                        principalColumn: "merkezId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_uyeId",
                table: "Randevu",
                column: "uyeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "GuzellikMerkezi");

            migrationBuilder.DropColumn(
                name: "musteriTelNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "uyeAdi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "uyeSoyadi",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}

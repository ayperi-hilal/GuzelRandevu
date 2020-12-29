using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class yeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "musteriAdi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "musteriEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "musteriId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "musteriSifre",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "musteriSoyadi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "musteriTelNo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GuzellikMerkezi",
                columns: table => new
                {
                    merkezId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    merkezAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merkezEmail = table.Column<int>(type: "int", nullable: false),
                    merkezAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merkezTelNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuzellikMerkezi", x => x.merkezId);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    musteriNoId = table.Column<int>(type: "int", nullable: false),
                    merkezNoId = table.Column<int>(type: "int", nullable: false),
                    musteriId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    merkezId = table.Column<int>(type: "int", nullable: true),
                    randevuZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    randevuPuani = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => new { x.merkezNoId, x.musteriNoId });
                    table.ForeignKey(
                        name: "FK_Randevu_AspNetUsers_musteriId",
                        column: x => x.musteriId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevu_GuzellikMerkezi_merkezId",
                        column: x => x.merkezId,
                        principalTable: "GuzellikMerkezi",
                        principalColumn: "merkezId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_merkezId",
                table: "Randevu",
                column: "merkezId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_musteriId",
                table: "Randevu",
                column: "musteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "GuzellikMerkezi");

            migrationBuilder.DropColumn(
                name: "musteriAdi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriSifre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriSoyadi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriTelNo",
                table: "AspNetUsers");
        }
    }
}

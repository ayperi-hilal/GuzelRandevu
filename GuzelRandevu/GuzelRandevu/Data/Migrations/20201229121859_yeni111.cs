using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class yeni111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "randevuZamani",
                table: "Randevu",
                newName: "randevuSaati");

            migrationBuilder.AddColumn<DateTime>(
                name: "randevuGunu",
                table: "Randevu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "hizmetler",
                table: "GuzellikMerkezi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cinsiyet",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "randevuGunu",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "hizmetler",
                table: "GuzellikMerkezi");

            migrationBuilder.DropColumn(
                name: "cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "randevuSaati",
                table: "Randevu",
                newName: "randevuZamani");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class yeni2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "musteriId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "musteriSifre",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

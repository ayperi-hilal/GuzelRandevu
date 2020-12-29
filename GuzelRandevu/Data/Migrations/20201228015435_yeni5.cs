using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class yeni5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "merkezEmail",
                table: "GuzellikMerkezi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "merkezResimUrl",
                table: "GuzellikMerkezi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "merkezResimUrl",
                table: "GuzellikMerkezi");

            migrationBuilder.AlterColumn<int>(
                name: "merkezEmail",
                table: "GuzellikMerkezi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

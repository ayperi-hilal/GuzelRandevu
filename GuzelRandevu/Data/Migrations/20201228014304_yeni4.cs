using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class yeni4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Randevu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Randevu",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

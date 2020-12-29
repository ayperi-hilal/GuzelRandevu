using Microsoft.EntityFrameworkCore.Migrations;

namespace GuzelRandevu.Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_musteriId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_GuzellikMerkezi_merkezId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_merkezId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_musteriId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "merkezId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "musteriId",
                table: "Randevu");

            migrationBuilder.AlterColumn<string>(
                name: "musteriNoId",
                table: "Randevu",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_musteriNoId",
                table: "Randevu",
                column: "musteriNoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_musteriNoId",
                table: "Randevu",
                column: "musteriNoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_GuzellikMerkezi_merkezNoId",
                table: "Randevu",
                column: "merkezNoId",
                principalTable: "GuzellikMerkezi",
                principalColumn: "merkezId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_musteriNoId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_GuzellikMerkezi_merkezNoId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_musteriNoId",
                table: "Randevu");

            migrationBuilder.AlterColumn<int>(
                name: "musteriNoId",
                table: "Randevu",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "merkezId",
                table: "Randevu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "musteriId",
                table: "Randevu",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_merkezId",
                table: "Randevu",
                column: "merkezId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_musteriId",
                table: "Randevu",
                column: "musteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_musteriId",
                table: "Randevu",
                column: "musteriId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_GuzellikMerkezi_merkezId",
                table: "Randevu",
                column: "merkezId",
                principalTable: "GuzellikMerkezi",
                principalColumn: "merkezId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

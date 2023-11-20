using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LapTop_NhanVien_MaNhanVien",
                table: "LapTop");

            migrationBuilder.DropIndex(
                name: "IX_LapTop_MaNhanVien",
                table: "LapTop");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "LapTop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaNhanVien",
                table: "LapTop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LapTop_MaNhanVien",
                table: "LapTop",
                column: "MaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_LapTop_NhanVien_MaNhanVien",
                table: "LapTop",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

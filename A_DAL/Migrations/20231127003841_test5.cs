using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_DiemThuong_MaDiemThuong",
                table: "HoaDon");

            migrationBuilder.DropTable(
                name: "DiemThuong");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_MaDiemThuong",
                table: "HoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiemThuong",
                columns: table => new
                {
                    MaDiemThuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiemCong = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemThuong", x => x.MaDiemThuong);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaDiemThuong",
                table: "HoaDon",
                column: "MaDiemThuong");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_DiemThuong_MaDiemThuong",
                table: "HoaDon",
                column: "MaDiemThuong",
                principalTable: "DiemThuong",
                principalColumn: "MaDiemThuong",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

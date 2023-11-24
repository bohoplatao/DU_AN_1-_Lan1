using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardDoHoa",
                columns: table => new
                {
                    MaCardDoHoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThongSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDoHoa", x => x.MaCardDoHoa);
                });

            migrationBuilder.CreateTable(
                name: "Chip",
                columns: table => new
                {
                    MaChip = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThongSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chip", x => x.MaChip);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    MaDanhGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DanhGias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.MaDanhGia);
                });

            migrationBuilder.CreateTable(
                name: "DiemThuong",
                columns: table => new
                {
                    MaDiemThuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiemCong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemThuong", x => x.MaDiemThuong);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LapTop",
                columns: table => new
                {
                    MaLaptop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLaptop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanNang = table.Column<float>(type: "real", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapTop", x => x.MaLaptop);
                });

            migrationBuilder.CreateTable(
                name: "ManHinh",
                columns: table => new
                {
                    MaManHinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManHinh", x => x.MaManHinh);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "OCung",
                columns: table => new
                {
                    MaOCung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungLuong = table.Column<int>(type: "int", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCung", x => x.MaOCung);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoai",
                columns: table => new
                {
                    MaPhanLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoai", x => x.MaPhanLoai);
                });

            migrationBuilder.CreateTable(
                name: "Pin",
                columns: table => new
                {
                    MaPin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungLuong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pin", x => x.MaPin);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    MaRam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bus = table.Column<int>(type: "int", nullable: false),
                    DungLuongRam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.MaRam);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHang",
                columns: table => new
                {
                    MaLoaiHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhaCungCap = table.Column<int>(type: "int", nullable: false),
                    TenLoaiHang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHang", x => x.MaLoaiHang);
                    table.ForeignKey(
                        name: "FK_LoaiHang_NhaCungCap_MaNhaCungCap",
                        column: x => x.MaNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaDiemThuong = table.Column<int>(type: "int", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: false),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_DiemThuong_MaDiemThuong",
                        column: x => x.MaDiemThuong,
                        principalTable: "DiemThuong",
                        principalColumn: "MaDiemThuong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    MaSale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    TenDotSale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.MaSale);
                    table.ForeignKey(
                        name: "FK_Sale_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LapTopCT",
                columns: table => new
                {
                    MaLaptopChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiHang = table.Column<int>(type: "int", nullable: false),
                    MaPin = table.Column<int>(type: "int", nullable: false),
                    MaPhanLoai = table.Column<int>(type: "int", nullable: false),
                    MaChip = table.Column<int>(type: "int", nullable: false),
                    MaRAM = table.Column<int>(type: "int", nullable: false),
                    MaCardDoHoa = table.Column<int>(type: "int", nullable: false),
                    MaLaptop = table.Column<int>(type: "int", nullable: false),
                    MaManHinh = table.Column<int>(type: "int", nullable: false),
                    MaOCung = table.Column<int>(type: "int", nullable: false),
                    MaHinhAnh = table.Column<int>(type: "int", nullable: false),
                    GiaBanDau = table.Column<float>(type: "real", nullable: false),
                    GiaBan = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapTopCT", x => x.MaLaptopChiTiet);
                    table.ForeignKey(
                        name: "FK_LapTopCT_CardDoHoa_MaCardDoHoa",
                        column: x => x.MaCardDoHoa,
                        principalTable: "CardDoHoa",
                        principalColumn: "MaCardDoHoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_Chip_MaChip",
                        column: x => x.MaChip,
                        principalTable: "Chip",
                        principalColumn: "MaChip",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_LapTop_MaLaptop",
                        column: x => x.MaLaptop,
                        principalTable: "LapTop",
                        principalColumn: "MaLaptop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_LoaiHang_MaLoaiHang",
                        column: x => x.MaLoaiHang,
                        principalTable: "LoaiHang",
                        principalColumn: "MaLoaiHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_ManHinh_MaManHinh",
                        column: x => x.MaManHinh,
                        principalTable: "ManHinh",
                        principalColumn: "MaManHinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_OCung_MaOCung",
                        column: x => x.MaOCung,
                        principalTable: "OCung",
                        principalColumn: "MaOCung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_PhanLoai_MaPhanLoai",
                        column: x => x.MaPhanLoai,
                        principalTable: "PhanLoai",
                        principalColumn: "MaPhanLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_Pin_MaPin",
                        column: x => x.MaPin,
                        principalTable: "Pin",
                        principalColumn: "MaPin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapTopCT_Ram_MaRAM",
                        column: x => x.MaRAM,
                        principalTable: "Ram",
                        principalColumn: "MaRam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleCT",
                columns: table => new
                {
                    MaSaleChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSale = table.Column<int>(type: "int", nullable: false),
                    MaLaptopChiTiet = table.Column<int>(type: "int", nullable: false),
                    GiaTriGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongApDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleCT", x => x.MaSaleChiTiet);
                    table.ForeignKey(
                        name: "FK_SaleCT_LapTopCT_MaLaptopChiTiet",
                        column: x => x.MaLaptopChiTiet,
                        principalTable: "LapTopCT",
                        principalColumn: "MaLaptopChiTiet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleCT_Sale_MaSale",
                        column: x => x.MaSale,
                        principalTable: "Sale",
                        principalColumn: "MaSale",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Serial",
                columns: table => new
                {
                    MaSerial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLaptopChiTiet = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serial", x => x.MaSerial);
                    table.ForeignKey(
                        name: "FK_Serial_LapTopCT_MaLaptopChiTiet",
                        column: x => x.MaLaptopChiTiet,
                        principalTable: "LapTopCT",
                        principalColumn: "MaLaptopChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    MaHoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    MaDanhGia = table.Column<int>(type: "int", nullable: false),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: false),
                    SoLuongXuat = table.Column<int>(type: "int", nullable: false),
                    MaSerial = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    SerialMaSerial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => x.MaHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_DanhGia_MaDanhGia",
                        column: x => x.MaDanhGia,
                        principalTable: "DanhGia",
                        principalColumn: "MaDanhGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_Serial_MaSerial",
                        column: x => x.MaSerial,
                        principalTable: "Serial",
                        principalColumn: "MaSerial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_Serial_SerialMaSerial",
                        column: x => x.SerialMaSerial,
                        principalTable: "Serial",
                        principalColumn: "MaSerial",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaDiemThuong",
                table: "HoaDon",
                column: "MaDiemThuong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaDanhGia",
                table: "HoaDonCT",
                column: "MaDanhGia");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaHoaDon",
                table: "HoaDonCT",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaSerial",
                table: "HoaDonCT",
                column: "MaSerial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_SerialMaSerial",
                table: "HoaDonCT",
                column: "SerialMaSerial");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaCardDoHoa",
                table: "LapTopCT",
                column: "MaCardDoHoa");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaChip",
                table: "LapTopCT",
                column: "MaChip");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaLaptop",
                table: "LapTopCT",
                column: "MaLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaLoaiHang",
                table: "LapTopCT",
                column: "MaLoaiHang");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaManHinh",
                table: "LapTopCT",
                column: "MaManHinh");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaOCung",
                table: "LapTopCT",
                column: "MaOCung");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaPhanLoai",
                table: "LapTopCT",
                column: "MaPhanLoai");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaPin",
                table: "LapTopCT",
                column: "MaPin");

            migrationBuilder.CreateIndex(
                name: "IX_LapTopCT_MaRAM",
                table: "LapTopCT",
                column: "MaRAM");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiHang_MaNhaCungCap",
                table: "LoaiHang",
                column: "MaNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaNhanVien",
                table: "Sale",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_SaleCT_MaLaptopChiTiet",
                table: "SaleCT",
                column: "MaLaptopChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_SaleCT_MaSale",
                table: "SaleCT",
                column: "MaSale");

            migrationBuilder.CreateIndex(
                name: "IX_Serial_MaLaptopChiTiet",
                table: "Serial",
                column: "MaLaptopChiTiet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "SaleCT");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Serial");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "DiemThuong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LapTopCT");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "CardDoHoa");

            migrationBuilder.DropTable(
                name: "Chip");

            migrationBuilder.DropTable(
                name: "LapTop");

            migrationBuilder.DropTable(
                name: "LoaiHang");

            migrationBuilder.DropTable(
                name: "ManHinh");

            migrationBuilder.DropTable(
                name: "OCung");

            migrationBuilder.DropTable(
                name: "PhanLoai");

            migrationBuilder.DropTable(
                name: "Pin");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}

﻿// <auto-generated />
using System;
using A_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A_DAL.Migrations
{
    [DbContext(typeof(QL_LapTopContext))]
    partial class QL_LapTopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_DAL.Model.CardDoHoa", b =>
                {
                    b.Property<int>("MaCardDoHoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCardDoHoa"), 1L, 1);

                    b.Property<string>("TenCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThongSo")
                        .HasColumnType("int");

                    b.HasKey("MaCardDoHoa");

                    b.ToTable("CardDoHoa");
                });

            modelBuilder.Entity("A_DAL.Model.Chip", b =>
                {
                    b.Property<int>("MaChip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChip"), 1L, 1);

                    b.Property<string>("TenChip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThongSo")
                        .HasColumnType("int");

                    b.HasKey("MaChip");

                    b.ToTable("Chip");
                });

            modelBuilder.Entity("A_DAL.Model.DanhGia", b =>
                {
                    b.Property<int>("MaDanhGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDanhGia"), 1L, 1);

                    b.Property<int>("DanhGias")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("MaDanhGia");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("A_DAL.Model.DiemThuong", b =>
                {
                    b.Property<int>("MaDiemThuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDiemThuong"), 1L, 1);

                    b.Property<int>("DiemCong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDiemThuong");

                    b.ToTable("DiemThuong");
                });

            modelBuilder.Entity("A_DAL.Model.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDon"), 1L, 1);

                    b.Property<string>("ChuThich")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaDiemThuong")
                        .HasColumnType("int");

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SoDienThoai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaDiemThuong");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("A_DAL.Model.HoaDonCT", b =>
                {
                    b.Property<int>("MaHoaDonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDonChiTiet"), 1L, 1);

                    b.Property<float>("Gia")
                        .HasColumnType("real");

                    b.Property<int>("MaDanhGia")
                        .HasColumnType("int");

                    b.Property<int>("MaHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("MaSerial")
                        .HasColumnType("int");

                    b.Property<int>("SerialMaSerial")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongXuat")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDonChiTiet");

                    b.HasIndex("MaDanhGia");

                    b.HasIndex("MaHoaDon");

                    b.HasIndex("MaSerial")
                        .IsUnique();

                    b.HasIndex("SerialMaSerial");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("A_DAL.Model.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SoDienThoai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Model.LapTop", b =>
                {
                    b.Property<int>("MaLaptop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLaptop"), 1L, 1);

                    b.Property<float>("CanNang")
                        .HasColumnType("real");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("TenLaptop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaLaptop");

                    b.ToTable("LapTop");
                });

            modelBuilder.Entity("A_DAL.Model.LapTopCT", b =>
                {
                    b.Property<int>("MaLaptopChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLaptopChiTiet"), 1L, 1);

                    b.Property<float>("GiaBan")
                        .HasColumnType("real");

                    b.Property<float>("GiaBanDau")
                        .HasColumnType("real");

                    b.Property<int>("MaCardDoHoa")
                        .HasColumnType("int");

                    b.Property<int>("MaChip")
                        .HasColumnType("int");

                    b.Property<int>("MaHinhAnh")
                        .HasColumnType("int");

                    b.Property<int>("MaLaptop")
                        .HasColumnType("int");

                    b.Property<int>("MaLoaiHang")
                        .HasColumnType("int");

                    b.Property<int>("MaManHinh")
                        .HasColumnType("int");

                    b.Property<int>("MaOCung")
                        .HasColumnType("int");

                    b.Property<int>("MaPhanLoai")
                        .HasColumnType("int");

                    b.Property<int>("MaPin")
                        .HasColumnType("int");

                    b.Property<int>("MaRAM")
                        .HasColumnType("int");

                    b.HasKey("MaLaptopChiTiet");

                    b.HasIndex("MaCardDoHoa");

                    b.HasIndex("MaChip");

                    b.HasIndex("MaLaptop");

                    b.HasIndex("MaLoaiHang");

                    b.HasIndex("MaManHinh");

                    b.HasIndex("MaOCung");

                    b.HasIndex("MaPhanLoai");

                    b.HasIndex("MaPin");

                    b.HasIndex("MaRAM");

                    b.ToTable("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.LoaiHang", b =>
                {
                    b.Property<int>("MaLoaiHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiHang"), 1L, 1);

                    b.Property<int>("MaNhaCungCap")
                        .HasColumnType("int");

                    b.Property<string>("TenLoaiHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiHang");

                    b.HasIndex("MaNhaCungCap");

                    b.ToTable("LoaiHang");
                });

            modelBuilder.Entity("A_DAL.Model.ManHinh", b =>
                {
                    b.Property<int>("MaManHinh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaManHinh"), 1L, 1);

                    b.Property<string>("LoaiManHinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TanSo")
                        .HasColumnType("int");

                    b.Property<string>("TenManHinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaManHinh");

                    b.ToTable("ManHinh");
                });

            modelBuilder.Entity("A_DAL.Model.NhaCungCap", b =>
                {
                    b.Property<int>("MaNCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNCC"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNCC");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("A_DAL.Model.NhanVien", b =>
                {
                    b.Property<int>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhanVien"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SoDienThoai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Model.OCung", b =>
                {
                    b.Property<int>("MaOCung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaOCung"), 1L, 1);

                    b.Property<int>("DungLuong")
                        .HasColumnType("int");

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaOCung");

                    b.ToTable("OCung");
                });

            modelBuilder.Entity("A_DAL.Model.PhanLoai", b =>
                {
                    b.Property<int>("MaPhanLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhanLoai"), 1L, 1);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhanLoai");

                    b.ToTable("PhanLoai");
                });

            modelBuilder.Entity("A_DAL.Model.Pin", b =>
                {
                    b.Property<int>("MaPin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPin"), 1L, 1);

                    b.Property<string>("DungLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPin");

                    b.ToTable("Pin");
                });

            modelBuilder.Entity("A_DAL.Model.Ram", b =>
                {
                    b.Property<int>("MaRam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaRam"), 1L, 1);

                    b.Property<int>("Bus")
                        .HasColumnType("int");

                    b.Property<int>("DungLuongRam")
                        .HasColumnType("int");

                    b.Property<string>("TenRam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaRam");

                    b.ToTable("Ram");
                });

            modelBuilder.Entity("A_DAL.Model.Sale", b =>
                {
                    b.Property<int>("MaSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSale"), 1L, 1);

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("TenDotSale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKT")
                        .HasColumnType("datetime2");

                    b.HasKey("MaSale");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("A_DAL.Model.SaleCT", b =>
                {
                    b.Property<int>("MaSaleChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSaleChiTiet"), 1L, 1);

                    b.Property<decimal>("GiaTriGiamGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaLaptopChiTiet")
                        .HasColumnType("int");

                    b.Property<int>("MaSale")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongApDung")
                        .HasColumnType("int");

                    b.HasKey("MaSaleChiTiet");

                    b.HasIndex("MaLaptopChiTiet");

                    b.HasIndex("MaSale");

                    b.ToTable("SaleCT");
                });

            modelBuilder.Entity("A_DAL.Model.Serial", b =>
                {
                    b.Property<int>("MaSerial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSerial"), 1L, 1);

                    b.Property<int>("MaLaptopChiTiet")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaSerial");

                    b.HasIndex("MaLaptopChiTiet");

                    b.ToTable("Serial");
                });

            modelBuilder.Entity("A_DAL.Model.HoaDon", b =>
                {
                    b.HasOne("A_DAL.Model.DiemThuong", "DiemThuong")
                        .WithMany("HoaDon")
                        .HasForeignKey("MaDiemThuong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.KhachHang", "KhachHang")
                        .WithMany("HoaDon")
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiemThuong");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Model.HoaDonCT", b =>
                {
                    b.HasOne("A_DAL.Model.DanhGia", "DanhGia")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("MaDanhGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Serial", null)
                        .WithOne("HoaDonCT")
                        .HasForeignKey("A_DAL.Model.HoaDonCT", "MaSerial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Serial", "Serial")
                        .WithMany()
                        .HasForeignKey("SerialMaSerial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhGia");

                    b.Navigation("HoaDon");

                    b.Navigation("Serial");
                });

            modelBuilder.Entity("A_DAL.Model.LapTopCT", b =>
                {
                    b.HasOne("A_DAL.Model.CardDoHoa", "CardDoHoa")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaCardDoHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Chip", "Chip")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaChip")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.LapTop", "LapTop")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.LoaiHang", "LoaiHang")
                        .WithMany("LapTopCTs")
                        .HasForeignKey("MaLoaiHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.ManHinh", "ManHinh")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaManHinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.OCung", "Ocung")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaOCung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.PhanLoai", "PhanLoai")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaPhanLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Pin", "Pin")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaPin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Ram", "Ram")
                        .WithMany("LapTopCT")
                        .HasForeignKey("MaRAM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardDoHoa");

                    b.Navigation("Chip");

                    b.Navigation("LapTop");

                    b.Navigation("LoaiHang");

                    b.Navigation("ManHinh");

                    b.Navigation("Ocung");

                    b.Navigation("PhanLoai");

                    b.Navigation("Pin");

                    b.Navigation("Ram");
                });

            modelBuilder.Entity("A_DAL.Model.LoaiHang", b =>
                {
                    b.HasOne("A_DAL.Model.NhaCungCap", "NhaCungCap")
                        .WithMany("LoaiHang")
                        .HasForeignKey("MaNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaCungCap");
                });

            modelBuilder.Entity("A_DAL.Model.Sale", b =>
                {
                    b.HasOne("A_DAL.Model.NhanVien", "NhanVien")
                        .WithMany("Sales")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Model.SaleCT", b =>
                {
                    b.HasOne("A_DAL.Model.LapTopCT", "LapTopCT")
                        .WithMany("SaleCTs")
                        .HasForeignKey("MaLaptopChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A_DAL.Model.Sale", "Sale")
                        .WithMany("SaleCT")
                        .HasForeignKey("MaSale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LapTopCT");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("A_DAL.Model.Serial", b =>
                {
                    b.HasOne("A_DAL.Model.LapTopCT", "LapTopCT")
                        .WithMany("Serials")
                        .HasForeignKey("MaLaptopChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.CardDoHoa", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.Chip", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.DanhGia", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("A_DAL.Model.DiemThuong", b =>
                {
                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("A_DAL.Model.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("A_DAL.Model.KhachHang", b =>
                {
                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("A_DAL.Model.LapTop", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.LapTopCT", b =>
                {
                    b.Navigation("SaleCTs");

                    b.Navigation("Serials");
                });

            modelBuilder.Entity("A_DAL.Model.LoaiHang", b =>
                {
                    b.Navigation("LapTopCTs");
                });

            modelBuilder.Entity("A_DAL.Model.ManHinh", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.NhaCungCap", b =>
                {
                    b.Navigation("LoaiHang");
                });

            modelBuilder.Entity("A_DAL.Model.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("A_DAL.Model.OCung", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.PhanLoai", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.Pin", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.Ram", b =>
                {
                    b.Navigation("LapTopCT");
                });

            modelBuilder.Entity("A_DAL.Model.Sale", b =>
                {
                    b.Navigation("SaleCT");
                });

            modelBuilder.Entity("A_DAL.Model.Serial", b =>
                {
                    b.Navigation("HoaDonCT")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

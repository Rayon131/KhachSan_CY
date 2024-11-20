﻿// <auto-generated />
using System;
using AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20241120033303_ks02")]
    partial class ks02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.Property<int>("MaDatPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDatPhong"));

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaPhongChiTiet")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PhongChiTietMaPhongChiTiet")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoNguoi")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDatPhong");

                    b.HasIndex("MaKhachHang")
                        .IsUnique()
                        .HasFilter("[MaKhachHang] IS NOT NULL");

                    b.HasIndex("PhongChiTietMaPhongChiTiet");

                    b.ToTable("DatPhongs");
                });

            modelBuilder.Entity("AppData.DichVu", b =>
                {
                    b.Property<int>("MaDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDichVu"));

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDichVu");

                    b.ToTable("DichVus");
                });

            modelBuilder.Entity("AppData.DichVuKhachDung", b =>
                {
                    b.Property<int>("MaDichVuKhachDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDichVuKhachDung"));

                    b.Property<int?>("DatPhongMaDatPhong")
                        .HasColumnType("int");

                    b.Property<int?>("DichVuMaDichVu")
                        .HasColumnType("int");

                    b.Property<int?>("MaDatPhong")
                        .HasColumnType("int");

                    b.Property<int?>("MaDichVu")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaDichVuKhachDung");

                    b.HasIndex("DatPhongMaDatPhong");

                    b.HasIndex("DichVuMaDichVu");

                    b.ToTable("DichVuKhachDungs");
                });

            modelBuilder.Entity("AppData.Gia", b =>
                {
                    b.Property<int>("MaGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGia"));

                    b.Property<decimal>("GiaBanDem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaCuoiTuan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNgayLe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNgayThuong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("MaPhongChiTiet")
                        .HasColumnType("int");

                    b.HasKey("MaGia");

                    b.ToTable("Gias");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDon"));

                    b.Property<int?>("KhachHangMaKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("KhachHangMaKhachHang");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("AppData.HoaDonChiTiet", b =>
                {
                    b.Property<int>("MaHoaDonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDonChiTiet"));

                    b.Property<int?>("DatPhongMaDatPhong")
                        .HasColumnType("int");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("HoaDon")
                        .HasColumnType("int");

                    b.Property<int?>("HoaDonEntityMaHoaDon")
                        .HasColumnType("int");

                    b.Property<int?>("MaDatPhong")
                        .HasColumnType("int");

                    b.Property<int>("MaDichVuKhachDung")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDonChiTiet");

                    b.HasIndex("DatPhongMaDatPhong");

                    b.HasIndex("HoaDonEntityMaHoaDon");

                    b.HasIndex("MaDichVuKhachDung");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"));

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaDatPhong")
                        .HasColumnType("int");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaiKhoanMaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.HasIndex("TaiKhoanMaTaiKhoan");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("AppData.LoaiPhong", b =>
                {
                    b.Property<int>("MaLoaiPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiPhong"));

                    b.Property<string>("TenLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiPhong");

                    b.ToTable("LoaiPhongs");
                });

            modelBuilder.Entity("AppData.NhanVien", b =>
                {
                    b.Property<int>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhanVien"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("AppData.Phong", b =>
                {
                    b.Property<int>("MaPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhong"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoaiPhongMaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<int>("MaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("gia")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaPhong");

                    b.HasIndex("LoaiPhongMaLoaiPhong");

                    b.ToTable("Phongs");
                });

            modelBuilder.Entity("AppData.PhongChiTiet", b =>
                {
                    b.Property<int>("MaPhongChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhongChiTiet"));

                    b.Property<int?>("LoaiPhongMaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<int?>("MaGia")
                        .HasColumnType("int");

                    b.Property<int?>("PhongMaPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoNguoi")
                        .HasColumnType("int");

                    b.HasKey("MaPhongChiTiet");

                    b.HasIndex("LoaiPhongMaLoaiPhong");

                    b.HasIndex("MaGia")
                        .IsUnique()
                        .HasFilter("[MaGia] IS NOT NULL");

                    b.HasIndex("PhongMaPhong");

                    b.ToTable("PhongChiTiets");
                });

            modelBuilder.Entity("AppData.Quyen", b =>
                {
                    b.Property<int>("MaQuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaQuyen"));

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaQuyen");

                    b.ToTable("Quyens");
                });

            modelBuilder.Entity("AppData.TaiKhoann", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTaiKhoan"));

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NhanVienMaNhanVien")
                        .HasColumnType("int");

                    b.Property<int?>("QuyenMaQuyen")
                        .HasColumnType("int");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.HasIndex("QuyenMaQuyen");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("AppData.ThuChi", b =>
                {
                    b.Property<int>("MaThuChi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaThuChi"));

                    b.Property<int?>("DatPhongMaDatPhong")
                        .HasColumnType("int");

                    b.Property<int>("MaDatPhong")
                        .HasColumnType("int");

                    b.Property<int>("MaHoaDonChiTiet")
                        .HasColumnType("int");

                    b.Property<int>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayGiaoDich")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NhanVienMaNhanVien")
                        .HasColumnType("int");

                    b.Property<decimal>("SoTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaThuChi");

                    b.HasIndex("DatPhongMaDatPhong");

                    b.HasIndex("MaHoaDonChiTiet");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.ToTable("ThuChis");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.HasOne("AppData.KhachHang", "KhachHang")
                        .WithOne("DatPhong")
                        .HasForeignKey("AppData.DatPhong", "MaKhachHang");

                    b.HasOne("AppData.PhongChiTiet", "PhongChiTiet")
                        .WithMany()
                        .HasForeignKey("PhongChiTietMaPhongChiTiet");

                    b.Navigation("KhachHang");

                    b.Navigation("PhongChiTiet");
                });

            modelBuilder.Entity("AppData.DichVuKhachDung", b =>
                {
                    b.HasOne("AppData.DatPhong", "DatPhong")
                        .WithMany("DichVuKhachDungs")
                        .HasForeignKey("DatPhongMaDatPhong");

                    b.HasOne("AppData.DichVu", "DichVu")
                        .WithMany("DichVuKhachDungs")
                        .HasForeignKey("DichVuMaDichVu");

                    b.Navigation("DatPhong");

                    b.Navigation("DichVu");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.HasOne("AppData.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangMaKhachHang");

                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.HoaDonChiTiet", b =>
                {
                    b.HasOne("AppData.DatPhong", "DatPhong")
                        .WithMany()
                        .HasForeignKey("DatPhongMaDatPhong");

                    b.HasOne("AppData.HoaDon", "HoaDonEntity")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("HoaDonEntityMaHoaDon");

                    b.HasOne("AppData.DichVuKhachDung", "DichVuKhachDung")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MaDichVuKhachDung")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DatPhong");

                    b.Navigation("DichVuKhachDung");

                    b.Navigation("HoaDonEntity");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.HasOne("AppData.TaiKhoann", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("TaiKhoanMaTaiKhoan");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("AppData.Phong", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany("phongs")
                        .HasForeignKey("LoaiPhongMaLoaiPhong");

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("AppData.PhongChiTiet", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany()
                        .HasForeignKey("LoaiPhongMaLoaiPhong");

                    b.HasOne("AppData.Gia", "Gia")
                        .WithOne("PhongChiTiet")
                        .HasForeignKey("AppData.PhongChiTiet", "MaGia");

                    b.HasOne("AppData.Phong", "Phong")
                        .WithMany("PhongChiTiets")
                        .HasForeignKey("PhongMaPhong");

                    b.Navigation("Gia");

                    b.Navigation("LoaiPhong");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("AppData.TaiKhoann", b =>
                {
                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("NhanVienMaNhanVien");

                    b.HasOne("AppData.Quyen", "Quyen")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("QuyenMaQuyen");

                    b.Navigation("NhanVien");

                    b.Navigation("Quyen");
                });

            modelBuilder.Entity("AppData.ThuChi", b =>
                {
                    b.HasOne("AppData.DatPhong", "DatPhong")
                        .WithMany()
                        .HasForeignKey("DatPhongMaDatPhong");

                    b.HasOne("AppData.HoaDonChiTiet", "HoaDonChiTiet")
                        .WithMany("ThuChis")
                        .HasForeignKey("MaHoaDonChiTiet")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany("ThuChis")
                        .HasForeignKey("NhanVienMaNhanVien");

                    b.Navigation("DatPhong");

                    b.Navigation("HoaDonChiTiet");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.Navigation("DichVuKhachDungs");
                });

            modelBuilder.Entity("AppData.DichVu", b =>
                {
                    b.Navigation("DichVuKhachDungs");
                });

            modelBuilder.Entity("AppData.DichVuKhachDung", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppData.Gia", b =>
                {
                    b.Navigation("PhongChiTiet");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppData.HoaDonChiTiet", b =>
                {
                    b.Navigation("ThuChis");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.Navigation("DatPhong");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("AppData.LoaiPhong", b =>
                {
                    b.Navigation("phongs");
                });

            modelBuilder.Entity("AppData.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("TaiKhoans");

                    b.Navigation("ThuChis");
                });

            modelBuilder.Entity("AppData.Phong", b =>
                {
                    b.Navigation("PhongChiTiets");
                });

            modelBuilder.Entity("AppData.Quyen", b =>
                {
                    b.Navigation("TaiKhoans");
                });
#pragma warning restore 612, 618
        }
    }
}

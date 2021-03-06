﻿// <auto-generated />
using System;
using Application.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200729074529_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.6.20312.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Application.Data.Entites.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Application.Data.Entites.Ban", b =>
                {
                    b.Property<string>("MaBan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaLoaiBan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenBan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBan");

                    b.HasIndex("MaLoaiBan");

                    b.ToTable("Ban");
                });

            modelBuilder.Entity("Application.Data.Entites.ChiTietHoaDonNhap", b =>
                {
                    b.Property<string>("MaHoaDonNhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNguyenLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<int>("KhuyenMai")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.HasKey("MaHoaDonNhap", "MaNguyenLieu");

                    b.HasIndex("MaNguyenLieu");

                    b.ToTable("ChiTietHoaDonNhap");
                });

            modelBuilder.Entity("Application.Data.Entites.ChiTietPDB", b =>
                {
                    b.Property<string>("MaMonAn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaPhieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<string>("MaLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.HasKey("MaMonAn", "MaPhieu");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaPhieu");

                    b.ToTable("ChiTietPDB");
                });

            modelBuilder.Entity("Application.Data.Entites.CongDung", b =>
                {
                    b.Property<string>("MaCongDung")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenCongDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaCongDung");

                    b.ToTable("CongDung");
                });

            modelBuilder.Entity("Application.Data.Entites.CongDungMonAn", b =>
                {
                    b.Property<string>("MaCongDung")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaMonAn")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaCongDung", "MaMonAn");

                    b.HasIndex("MaMonAn");

                    b.ToTable("CongDungMonAn");
                });

            modelBuilder.Entity("Application.Data.Entites.HoaDonNhap", b =>
                {
                    b.Property<string>("MaHoaDonNhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhaCungCap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.HasKey("MaHoaDonNhap");

                    b.HasIndex("MaNhaCungCap");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDonNhap");
                });

            modelBuilder.Entity("Application.Data.Entites.KhachHang", b =>
                {
                    b.Property<string>("MaKhachHang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("Application.Data.Entites.LoaiBan", b =>
                {
                    b.Property<string>("MaLoaiBan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenLoaiBan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiBan");

                    b.ToTable("LoaiBan");
                });

            modelBuilder.Entity("Application.Data.Entites.LoaiMonAn", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiMonAn");
                });

            modelBuilder.Entity("Application.Data.Entites.MonAn", b =>
                {
                    b.Property<string>("MaMonAn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CachLam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("EditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenMonAn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("YeuCau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaMonAn");

                    b.HasIndex("MaLoai");

                    b.ToTable("MonAn");
                });

            modelBuilder.Entity("Application.Data.Entites.NguyenLieu", b =>
                {
                    b.Property<string>("MaNguyenLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChongChiDinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DonGiaBan")
                        .HasColumnType("float");

                    b.Property<double>("DonGiaNhap")
                        .HasColumnType("float");

                    b.Property<string>("DonViTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenNguyenLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YeuCau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNguyenLieu");

                    b.ToTable("NguyenLieu");
                });

            modelBuilder.Entity("Application.Data.Entites.NguyenLieuMonAn", b =>
                {
                    b.Property<string>("MaNguyenLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaMonAn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaNguyenLieu", "MaMonAn");

                    b.HasIndex("MaMonAn");

                    b.ToTable("NguyenLieuMonAn");
                });

            modelBuilder.Entity("Application.Data.Entites.NhaCungCap", b =>
                {
                    b.Property<string>("MaNhaCungCap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhaCungCap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhaCungCap");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("Application.Data.Entites.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaQue")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.HasIndex("MaQue");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("Application.Data.Entites.PhieuDatBan", b =>
                {
                    b.Property<string>("MaPhieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaBan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaKhach")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayDung")
                        .HasColumnType("datetime2");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.HasKey("MaPhieu");

                    b.HasIndex("MaBan");

                    b.HasIndex("MaKhach");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("PhieuDatBan");
                });

            modelBuilder.Entity("Application.Data.Entites.QueQuan", b =>
                {
                    b.Property<string>("MaQue")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenQue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaQue");

                    b.ToTable("QueQuan");
                });

            modelBuilder.Entity("Application.Data.Entites.Ban", b =>
                {
                    b.HasOne("Application.Data.Entites.LoaiBan", "LoaiBan")
                        .WithMany("Bans")
                        .HasForeignKey("MaLoaiBan");
                });

            modelBuilder.Entity("Application.Data.Entites.ChiTietHoaDonNhap", b =>
                {
                    b.HasOne("Application.Data.Entites.HoaDonNhap", "HoaDonNhap")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("MaHoaDonNhap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Data.Entites.NguyenLieu", "NguyenLieu")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("MaNguyenLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Data.Entites.ChiTietPDB", b =>
                {
                    b.HasOne("Application.Data.Entites.LoaiMonAn", "LoaiMonAn")
                        .WithMany("ChiTietPdbs")
                        .HasForeignKey("MaLoai");

                    b.HasOne("Application.Data.Entites.MonAn", "MonAn")
                        .WithMany("ChiTietPdbs")
                        .HasForeignKey("MaPhieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Data.Entites.PhieuDatBan", "PhieuDatBan")
                        .WithMany("ChiTietPdbs")
                        .HasForeignKey("MaPhieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Data.Entites.CongDungMonAn", b =>
                {
                    b.HasOne("Application.Data.Entites.CongDung", "CongDung")
                        .WithMany("CongDungMonAns")
                        .HasForeignKey("MaCongDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Data.Entites.MonAn", "MonAn")
                        .WithMany("CongDungMonAns")
                        .HasForeignKey("MaMonAn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Data.Entites.HoaDonNhap", b =>
                {
                    b.HasOne("Application.Data.Entites.NhaCungCap", "NhaCungCap")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("MaNhaCungCap");

                    b.HasOne("Application.Data.Entites.NhanVien", "NhanVien")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("Application.Data.Entites.MonAn", b =>
                {
                    b.HasOne("Application.Data.Entites.LoaiMonAn", "LoaiMonAn")
                        .WithMany("MonAns")
                        .HasForeignKey("MaLoai");
                });

            modelBuilder.Entity("Application.Data.Entites.NguyenLieuMonAn", b =>
                {
                    b.HasOne("Application.Data.Entites.MonAn", "MonAn")
                        .WithMany("NguyenLieuMonAns")
                        .HasForeignKey("MaMonAn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Data.Entites.NguyenLieu", "NguyenLieu")
                        .WithMany("NguyenLieuMonAns")
                        .HasForeignKey("MaNguyenLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Data.Entites.NhanVien", b =>
                {
                    b.HasOne("Application.Data.Entites.QueQuan", "QueQuan")
                        .WithMany("NhanVien")
                        .HasForeignKey("MaQue");
                });

            modelBuilder.Entity("Application.Data.Entites.PhieuDatBan", b =>
                {
                    b.HasOne("Application.Data.Entites.Ban", "Ban")
                        .WithMany("PhieuDatBans")
                        .HasForeignKey("MaBan");

                    b.HasOne("Application.Data.Entites.KhachHang", "KhachHang")
                        .WithMany("PhieuDatBans")
                        .HasForeignKey("MaKhach");

                    b.HasOne("Application.Data.Entites.NhanVien", "NhanVien")
                        .WithMany("PhieuDatBans")
                        .HasForeignKey("MaNhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}

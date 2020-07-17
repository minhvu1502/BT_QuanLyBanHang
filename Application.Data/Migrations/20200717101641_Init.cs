using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CongDung",
                columns: table => new
                {
                    MaCongDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCongDung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongDung", x => x.MaCongDung);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiBan",
                columns: table => new
                {
                    MaLoaiBan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLoaiBan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBan", x => x.MaLoaiBan);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMonAn",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMonAn", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieu",
                columns: table => new
                {
                    MaNguyenLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGiaNhap = table.Column<double>(type: "float", nullable: false),
                    DonGiaBan = table.Column<double>(type: "float", nullable: false),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChongChiDinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieu", x => x.MaNguyenLieu);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNhaCungCap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "QueQuan",
                columns: table => new
                {
                    MaQue = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenQue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueQuan", x => x.MaQue);
                });

            migrationBuilder.CreateTable(
                name: "Ban",
                columns: table => new
                {
                    MaBan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiBan = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ban", x => x.MaBan);
                    table.ForeignKey(
                        name: "FK_Ban_LoaiBan_MaLoaiBan",
                        column: x => x.MaLoaiBan,
                        principalTable: "LoaiBan",
                        principalColumn: "MaLoaiBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonAn",
                columns: table => new
                {
                    MaMonAn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMonAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CachLam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAn", x => x.MaMonAn);
                    table.ForeignKey(
                        name: "FK_MonAn_LoaiMonAn_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiMonAn",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaQue = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_QueQuan_MaQue",
                        column: x => x.MaQue,
                        principalTable: "QueQuan",
                        principalColumn: "MaQue",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CongDungMonAn",
                columns: table => new
                {
                    MaCongDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonAn = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongDungMonAn", x => new { x.MaCongDung, x.MaMonAn });
                    table.ForeignKey(
                        name: "FK_CongDungMonAn_CongDung_MaCongDung",
                        column: x => x.MaCongDung,
                        principalTable: "CongDung",
                        principalColumn: "MaCongDung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongDungMonAn_MonAn_MaMonAn",
                        column: x => x.MaMonAn,
                        principalTable: "MonAn",
                        principalColumn: "MaMonAn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieuMonAn",
                columns: table => new
                {
                    MaNguyenLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonAn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieuMonAn", x => new { x.MaNguyenLieu, x.MaMonAn });
                    table.ForeignKey(
                        name: "FK_NguyenLieuMonAn_MonAn_MaMonAn",
                        column: x => x.MaMonAn,
                        principalTable: "MonAn",
                        principalColumn: "MaMonAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguyenLieuMonAn_NguyenLieu_MaNguyenLieu",
                        column: x => x.MaNguyenLieu,
                        principalTable: "NguyenLieu",
                        principalColumn: "MaNguyenLieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhap",
                columns: table => new
                {
                    MaHoaDonNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNhaCungCap = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonNhap", x => x.MaHoaDonNhap);
                    table.ForeignKey(
                        name: "FK_HoaDonNhap_NhaCungCap_MaNhaCungCap",
                        column: x => x.MaNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNhaCungCap",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonNhap_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatBan",
                columns: table => new
                {
                    MaPhieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    MaBan = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaKhach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatBan", x => x.MaPhieu);
                    table.ForeignKey(
                        name: "FK_PhieuDatBan_Ban_MaBan",
                        column: x => x.MaBan,
                        principalTable: "Ban",
                        principalColumn: "MaBan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatBan_KhachHang_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatBan_NhanVien_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonNhap",
                columns: table => new
                {
                    MaNguyenLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHoaDonNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    KhuyenMai = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonNhap", x => new { x.MaHoaDonNhap, x.MaNguyenLieu });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_HoaDonNhap_MaHoaDonNhap",
                        column: x => x.MaHoaDonNhap,
                        principalTable: "HoaDonNhap",
                        principalColumn: "MaHoaDonNhap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_NguyenLieu_MaNguyenLieu",
                        column: x => x.MaNguyenLieu,
                        principalTable: "NguyenLieu",
                        principalColumn: "MaNguyenLieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPDB",
                columns: table => new
                {
                    MaPhieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonAn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPDB", x => new { x.MaMonAn, x.MaPhieu });
                    table.ForeignKey(
                        name: "FK_ChiTietPDB_LoaiMonAn_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiMonAn",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPDB_MonAn_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "MonAn",
                        principalColumn: "MaMonAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPDB_PhieuDatBan_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "PhieuDatBan",
                        principalColumn: "MaPhieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ban_MaLoaiBan",
                table: "Ban",
                column: "MaLoaiBan");

            migrationBuilder.CreateIndex(
                name: "IX_CongDungMonAn_MaMonAn",
                table: "CongDungMonAn",
                column: "MaMonAn");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhap_MaNguyenLieu",
                table: "ChiTietHoaDonNhap",
                column: "MaNguyenLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPDB_MaLoai",
                table: "ChiTietPDB",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPDB_MaPhieu",
                table: "ChiTietPDB",
                column: "MaPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_MaNhaCungCap",
                table: "HoaDonNhap",
                column: "MaNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_NhanVienMaNhanVien",
                table: "HoaDonNhap",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_MonAn_MaLoai",
                table: "MonAn",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NguyenLieuMonAn_MaMonAn",
                table: "NguyenLieuMonAn",
                column: "MaMonAn");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaQue",
                table: "NhanVien",
                column: "MaQue");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatBan_MaBan",
                table: "PhieuDatBan",
                column: "MaBan");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatBan_MaNhanVien",
                table: "PhieuDatBan",
                column: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "CongDungMonAn");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhap");

            migrationBuilder.DropTable(
                name: "ChiTietPDB");

            migrationBuilder.DropTable(
                name: "NguyenLieuMonAn");

            migrationBuilder.DropTable(
                name: "CongDung");

            migrationBuilder.DropTable(
                name: "HoaDonNhap");

            migrationBuilder.DropTable(
                name: "PhieuDatBan");

            migrationBuilder.DropTable(
                name: "MonAn");

            migrationBuilder.DropTable(
                name: "NguyenLieu");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "Ban");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiMonAn");

            migrationBuilder.DropTable(
                name: "LoaiBan");

            migrationBuilder.DropTable(
                name: "QueQuan");
        }
    }
}

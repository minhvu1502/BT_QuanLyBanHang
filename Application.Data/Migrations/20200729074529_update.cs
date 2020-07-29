using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonNhap_NhanVien_NhanVienMaNhanVien",
                table: "HoaDonNhap");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonNhap_NhanVienMaNhanVien",
                table: "HoaDonNhap");

            migrationBuilder.DropColumn(
                name: "NhanVienMaNhanVien",
                table: "HoaDonNhap");

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "HoaDonNhap",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_MaNhanVien",
                table: "HoaDonNhap",
                column: "MaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonNhap_NhanVien_MaNhanVien",
                table: "HoaDonNhap",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonNhap_NhanVien_MaNhanVien",
                table: "HoaDonNhap");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonNhap_MaNhanVien",
                table: "HoaDonNhap");

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "HoaDonNhap",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhanVienMaNhanVien",
                table: "HoaDonNhap",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_NhanVienMaNhanVien",
                table: "HoaDonNhap",
                column: "NhanVienMaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonNhap_NhanVien_NhanVienMaNhanVien",
                table: "HoaDonNhap",
                column: "NhanVienMaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

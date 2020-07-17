using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class HoaDonNhap
    {
        public string MaHoaDonNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTien { get; set; }
        public NhanVien NhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public string MaNhaCungCap { get; set; }
        public List<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}

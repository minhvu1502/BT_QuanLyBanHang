using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class ChiTietHoaDonNhap
    {
        public string MaNguyenLieu { get; set; }
        public string MaHoaDonNhap { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public int KhuyenMai { get; set; }
        public double ThanhTien { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public HoaDonNhap HoaDonNhap { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class PhieuDatBan
    {
        public string MaPhieu { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayDung { get; set; }
        public double TongTien { get; set; }
        public string MaBan { get; set; }
        public string MaKhach { get; set; }
        public string MaNhanVien { get; set; }
        public List<ChiTietPDB> ChiTietPdbs { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public Ban Ban { get; set; }
    }
}

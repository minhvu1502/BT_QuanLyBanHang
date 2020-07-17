using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public QueQuan QueQuan { get; set; }
        public string MaQue { get; set; }
        public List<HoaDonNhap> HoaDonNhaps { get; set; }
        public List<PhieuDatBan> PhieuDatBans { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class NhaCungCap
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public List<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}

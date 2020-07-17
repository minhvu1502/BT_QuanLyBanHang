using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Application.Data.Entites
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public List<PhieuDatBan> PhieuDatBans { get; set; }
    }
}

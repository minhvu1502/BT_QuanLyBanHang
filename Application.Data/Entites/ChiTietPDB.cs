using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class ChiTietPDB
    {
        public string MaPhieu { get; set; }
        public string MaMonAn { get; set; }
        public string MaLoai { get; set; }
        public int SoLuong { get; set; }
        public double GiamGia { get; set; }
        public double ThanhTien { get; set; }
        public PhieuDatBan PhieuDatBan { get; set; }
        public MonAn MonAn { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class MonAn
    {
        public string MaMonAn { get; set; }
        public string YeuCau { get; set; }
        public string TenMonAn { get; set; }
        public string CachLam { get; set; }
        public double DonGia { get; set; }
        public bool TrangThai { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public string MaLoai { get; set; }
        public List<CongDungMonAn> CongDungMonAns { get; set; }
        public List<ChiTietPDB> ChiTietPdbs { get; set; }
        public List<NguyenLieuMonAn> NguyenLieuMonAns { get; set; }
    }
}

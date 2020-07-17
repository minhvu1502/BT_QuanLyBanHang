using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class NguyenLieu
   {
       public string MaNguyenLieu { get; set; }
       public string TenNguyenLieu { get; set; }
       public int SoLuong { get; set; }
       public string DonViTinh { get; set; }
       public double DonGiaNhap { get; set; }
       public double DonGiaBan { get; set; }
       public string YeuCau { get; set; }
       public string ChongChiDinh { get; set; }
       public List<NguyenLieuMonAn> NguyenLieuMonAns { get; set; }
       public List<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}

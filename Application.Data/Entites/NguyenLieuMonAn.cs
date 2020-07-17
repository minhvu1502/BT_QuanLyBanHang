using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class NguyenLieuMonAn
    {
        public NguyenLieu NguyenLieu { get; set; }
        public MonAn MonAn { get; set; }
        public string MaNguyenLieu { get; set; }
        public string MaMonAn { get; set; }
        public int SoLuong { get; set; }
    }
}

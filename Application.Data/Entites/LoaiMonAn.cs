using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class LoaiMonAn
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public List<MonAn> MonAns { get; set; }
        public List<ChiTietPDB> ChiTietPdbs { get; set; }
    }
}

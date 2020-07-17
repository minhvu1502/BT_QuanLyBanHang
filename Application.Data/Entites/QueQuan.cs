using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class QueQuan
    {
        public string MaQue { get; set; }
        public string TenQue { get; set; }
        public List<NhanVien> NhanVien { get; set; }
        public bool TrangThai { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
    }
}

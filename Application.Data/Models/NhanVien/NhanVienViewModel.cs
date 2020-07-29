using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Models.NhanVien
{
    public class NhanVienViewModel
    {
        public string MaNhanVien { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public string MaQue { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class Ban
    {
        public string MaBan { get; set; }
        public string TenBan { get; set; }
        public string MaLoaiBan { get; set; }
        public LoaiBan LoaiBan { get; set; }
        public List<PhieuDatBan> PhieuDatBans { get; set; }

    }
}

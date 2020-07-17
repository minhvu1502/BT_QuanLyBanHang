using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class LoaiBan
    {
        public string MaLoaiBan { get; set; }
        public string TenLoaiBan { get; set; }
        public List<Ban> Bans { get; set; }
    }
}

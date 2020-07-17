using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class CongDung
   {
       public string MaCongDung { get; set; }
       public string TenCongDung { get; set; }
       public List<CongDungMonAn> CongDungMonAns { get; set; }
   }
}

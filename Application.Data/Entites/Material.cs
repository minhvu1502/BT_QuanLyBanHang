using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class Material
   {
       public string Id { get; set; }
       public string Name { get; set; }
       public int Quantity { get; set; }
       public string Unity { get; set; }
       public double InvoiceImport { get; set; }
       public double InvoiceExport { get; set; }
       public string Effect { get; set; }
       public string Request { get; set; }
       public string Contraindication { get; set; }
    }
}

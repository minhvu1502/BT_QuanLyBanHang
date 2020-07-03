using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class ImportBill
    {
        public string Id { get; set; }
        public DateTime DayImport { get; set; }
        public double Price { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
    }
}

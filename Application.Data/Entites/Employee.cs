using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public Country Country { get; set; }
        public string CountryId { get; set; }
        public List<ImportBill> ImportBills { get; set; }
    }
}

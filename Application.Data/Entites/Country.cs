using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
    }
}

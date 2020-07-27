using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Models.Account
{
   public class AccountModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Models.Login
{
   public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

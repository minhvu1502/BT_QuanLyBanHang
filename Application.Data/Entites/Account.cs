﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class Account
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}

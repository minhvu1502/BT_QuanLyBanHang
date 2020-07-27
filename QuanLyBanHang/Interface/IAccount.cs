using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Entites;
using Application.Data.Models.Account;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Common;

namespace QuanLyBanHang.Interface
{
   public interface IAccount
   {
       List<Account> GetAll();
       bool Register(AccountModel account);
   }
}

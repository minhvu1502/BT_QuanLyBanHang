using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Entites;

namespace QuanLyBanHang.Interface
{
   public interface IAccount
   {
       Task<List<Account>> GetAll();
   }
}

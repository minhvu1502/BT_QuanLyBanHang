using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Context;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Interface;

namespace QuanLyBanHang.Repositories
{
    public class AccountRepository:IAccount
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public AccountRepository()
        {
        }
        public async Task<List<Account>> GetAll()
        {
            return await _db.Accounts.ToListAsync();
        }
    }
}

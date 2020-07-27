using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models.Login;
using QuanLyBanHang.Common;

namespace QuanLyBanHang.Interface
{
    public interface ILogin
    {
        int CheckLogin(LoginModel loginModel);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models.QueQuan;

namespace QuanLyBanHang.Interface
{
    public interface IQueQuan
    {
        List<QueViewModel> GetAll();
    }
}

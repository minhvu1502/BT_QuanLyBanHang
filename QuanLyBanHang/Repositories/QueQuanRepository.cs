using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Context;
using Application.Data.Models.QueQuan;
using QuanLyBanHang.Interface;

namespace QuanLyBanHang.Repositories
{
    public class QueQuanRepository:IQueQuan
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public List<QueViewModel> GetAll()
        {
            List<QueViewModel> list = new List<QueViewModel>();
            foreach (var item in db.QueQuans.ToList())
            {
                list.Add(new QueViewModel()
                {
                    MaQue = item.MaQue,
                    TenQue = item.TenQue,
                    CreatedBy = item.CreatedBy,
                    EditedBy = item.EditedBy,
                    TrangThai = item.TrangThai
                });   
            }
            return list;
        }
    }
}

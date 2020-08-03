using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Context;
using Application.Data.Entites;
using Application.Data.Models.QueQuan;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
                    TrangThai = item.TrangThai.ToString()
                });   
            }
            return list;
        }
        [HttpPost]
        public bool AddHometown(QueViewModel model)
        {
            QueQuan queQuan = new QueQuan()
            {
                MaQue = model.MaQue,
                TenQue = model.TenQue,
                TrangThai = Convert.ToBoolean(model.TrangThai)
            };
            db.QueQuans.Add(queQuan);
            db.SaveChanges();
            return true;
        }

        public bool EditHomeTown(QueViewModel model)
        {
            try
            {
                var x = db.QueQuans.FirstOrDefault(x => x.MaQue == model.MaQue);
                x.TenQue = model.TenQue;
                x.TrangThai = Convert.ToBoolean(model.TrangThai);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteHomeTown(string MaQue)
        {
            try
            {
                var x = db.NhanViens.Find(MaQue);
                if (x != null)
                {
                    db.NhanViens.RemoveRange(x);
                }
                var y = db.QueQuans.FirstOrDefault(t => t.MaQue == MaQue);
                db.QueQuans.Remove(y);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateStatus(HomeEditStatus status)
        {
            try
            {
                var x = db.QueQuans.FirstOrDefault(x => x.MaQue == status.maQue);
                if (status.Status == "True")
                {
                    x.TrangThai = false;
                }
                else
                {
                    x.TrangThai = true;
                }

                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

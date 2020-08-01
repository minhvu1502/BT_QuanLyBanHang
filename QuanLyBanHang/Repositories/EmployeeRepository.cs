using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Context;
using Application.Data.Entites;
using Application.Data.Models.NhanVien;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Interface;

namespace QuanLyBanHang.Repositories
{
    public class EmployeeRepository:INhanVien
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public List<NhanVienViewModel> GetAllEmployees()
        {
            List<NhanVienViewModel> lists = new List<NhanVienViewModel>();
            List<NhanVien> listNhanViens = new List<NhanVien>();
            listNhanViens = db.NhanViens.ToList();
            foreach (var item in listNhanViens)
            {
                lists.Add(new NhanVienViewModel()
                {
                    MaNhanVien = item.MaNhanVien,
                    Ten = item.Ten,
                    GioiTinh = item.GioiTinh,
                    NgaySinh = item.NgaySinh.ToString("yyyy-MM-dd"),
                    DiaChi = item.DiaChi,
                    MaQue = item.MaQue,
                    SoDienThoai = item.SoDienThoai,
                    Status = item.Status
                });
            }
            return lists;
        }

        public NhanVienViewModel GetEmployeeById(string Id)
        {
            var item = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == Id);
            NhanVienViewModel model = new NhanVienViewModel()
            {
                MaNhanVien = item.MaNhanVien,
                Ten = item.Ten,
                GioiTinh = item.GioiTinh,
                NgaySinh = item.NgaySinh.ToString("yyyy/MM/dd"),
                DiaChi = item.DiaChi,
                MaQue = item.MaQue,
                SoDienThoai = item.SoDienThoai
            };
            return model;
        }

        public bool AddEmployee(NhanVienViewModel model)
        {
            try
            {
                var check = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == model.MaNhanVien);
                if (check == null)
                {
                    NhanVien nhanVien = new NhanVien()
                    {
                        MaNhanVien = model.MaNhanVien,
                        Ten = model.Ten,
                        GioiTinh = model.GioiTinh,
                        NgaySinh = Convert.ToDateTime(model.NgaySinh),
                        DiaChi = model.DiaChi,
                        MaQue = model.MaQue,
                        SoDienThoai = model.SoDienThoai
                    };
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteEmployee(string Id)
        {
            try
            {
                var nhanvien = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == Id);
                if (nhanvien != null)
                {
                    var listPdb = from x in db.PhieuDatBans
                        where x.MaNhanVien == Id
                        select x;
                    var listHdn = from x in db.HoaDonNhaps
                        where x.MaNhanVien == Id
                        select x;
                    db.PhieuDatBans.RemoveRange(listPdb);
                    db.HoaDonNhaps.RemoveRange(listHdn);
                    db.NhanViens.Remove(nhanvien);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditEmployee(NhanVienViewModel model)
        {
            var employee = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == model.MaNhanVien);
            if (employee == null)
            {
                return false;
            }   
            employee.Ten = model.Ten;
            employee.CreatedBy = model.CreatedBy;
            employee.DiaChi = model.DiaChi;
            employee.GioiTinh = model.GioiTinh;
            employee.NgaySinh = Convert.ToDateTime(model.NgaySinh);
            employee.SoDienThoai = model.SoDienThoai;
            employee.MaQue = model.MaQue;
            db.SaveChanges();
            return true;
        }
        public bool UpdateStatus(EditStatus status)
        {
            var employee = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == status.MaNhanVien);
            if (employee == null)
            {
                return false;
            }
            employee.Status = !status.Status;
            db.SaveChanges();
            return true;
        }
    }
}

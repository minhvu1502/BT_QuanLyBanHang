using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Entites;
using Application.Data.Models.NhanVien;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyBanHang.Interface
{
   public interface INhanVien
   {
       List<NhanVienViewModel> GetAllEmployees();
       NhanVienViewModel GetEmployeeById(string Id);
       bool AddEmployee(NhanVienViewModel model);
       bool DeleteEmployee(string Id);
       bool EditEmployee(NhanVienViewModel model);
       bool UpdateStatus(EditStatus status);
   }
}

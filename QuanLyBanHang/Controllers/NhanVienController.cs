using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models.NhanVien;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Interface;

namespace QuanLyBanHang.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVien _nhanVien;
        public NhanVienController(INhanVien nhanVien)
        {
            _nhanVien = nhanVien;
        }
        [HttpGet]
        public ActionResult GetAllNhanVien()
        {
            return Ok(_nhanVien.GetAllEmployees());
        }
        [HttpGet("{Id}", Name = "GetEmployeeById")]
        public ActionResult GetEmployeeById(string Id)
        {
            return Ok(_nhanVien.GetEmployeeById(Id));
        }
        [HttpPost]
        public ActionResult AddEmployee(NhanVienViewModel model)
        {
            return Ok(_nhanVien.AddEmployee(model));
        }

        [HttpGet("{Id}", Name = "DeleteEmployee")]
        public ActionResult DeleteEmployee(string Id)
        {
            return Ok(_nhanVien.DeleteEmployee(Id));
        }
        [HttpPost]
        public ActionResult EditEmployee(NhanVienViewModel model)
        {
            return Ok(_nhanVien.EditEmployee(model));
        }

        [HttpPost]
        public ActionResult UpdateStatus(EditStatus status)
        {
            return Ok(_nhanVien.UpdateStatus(status));
        }
    }
}
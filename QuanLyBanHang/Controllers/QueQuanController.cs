using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Interface;

namespace QuanLyBanHang.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QueQuanController : ControllerBase
    {
        private IQueQuan _queQuan;

        public QueQuanController(IQueQuan queQuan)
        {
            _queQuan = queQuan;
        }
        public ActionResult GetAll()
        {
            return Ok(_queQuan.GetAll());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.Models.QueQuan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration;
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

        public ActionResult AddHomeTown(QueViewModel model)
        {
            return Ok(_queQuan.AddHometown(model));
        }
        [HttpPost]
        public ActionResult EditHomeTown(QueViewModel model)
        {
            return Ok(_queQuan.EditHomeTown(model));
        }

        [HttpGet("{maQue}",Name = "DeleteHometown")]
        public ActionResult DeleteHomeTown(string maQue)
        {
            return Ok(_queQuan.DeleteHomeTown(maQue));
        }
    }
}
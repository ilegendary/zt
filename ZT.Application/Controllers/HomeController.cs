using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZT.Business;
using ZT.Model;

namespace ZT.Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LockControl(string sn, string cmdType)
        {
            
            return Json("LockControl");
        }

        public IActionResult GetLockStatus(string sn)
        {
            GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
            return Json("");
        }
    }
}
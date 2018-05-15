using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZT.Business;
using ZT.DTO;
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
            GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
            if (cmdType == "uplock")
            {
                terminalBLL.UpLock(sn);
            }

            if (cmdType == "downlock")
            {
                terminalBLL.DownLock(sn);
            }

            return Json("LockControl");
        }

        public IActionResult GetLockStatus(string sn)
        {
            GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
            GroundLockTerminalInfo terminalInfo = terminalBLL.GetTerminalStatus(sn);
            return Json(terminalInfo.Status);
        }
    }
}
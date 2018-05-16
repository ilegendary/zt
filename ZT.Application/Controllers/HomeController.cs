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
        GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
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

        public IActionResult GetUpLockResult(string sn)
        {
            GroundLockTerminalInfo terminalInfo = terminalBLL.GetTerminalStatus(sn);

            if (terminalInfo.Status == ((int)ZTEnum.GroudLockStatus.LockUp_NoBooking).ToString() || terminalInfo.Status == ((int)ZTEnum.GroudLockStatus.LockUp_Booking).ToString())
            {
                return Json("{\"success\":\"1\",\"msg\":\"操作成功\"}");
            }
            else
            {
                return Json("{\"success\":\"0\",\"msg\":\"正在执行\"}");
            }
        }

        public IActionResult GetDownLockResult(string sn)
        {
            GroundLockTerminalInfo terminalInfo = terminalBLL.GetTerminalStatus(sn);

            if (terminalInfo.Status == ((int)ZTEnum.GroudLockStatus.LockDown_Left).ToString() || terminalInfo.Status == ((int)ZTEnum.GroudLockStatus.LockDown_Wating).ToString())
            {
                return Json("{\"success\":\"1\",\"msg\":\"操作成功\"}");
            }
            else
            {
                return Json("{\"success\":\"0\",\"msg\":\"正在执行\"}");
            }
        }


        public IActionResult GetLockStatus(string sn)
        {
            GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
            GroundLockTerminalInfo terminalInfo = terminalBLL.GetTerminalStatus(sn);
            return Json(terminalInfo.Status);
        }
    }
}
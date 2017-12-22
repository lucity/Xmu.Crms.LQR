using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public IActionResult ClassManage()
        {
            return View();
        }
        public IActionResult TeacherMainUI()
        {
            return View();
        }
        public IActionResult CreateSchool()
        {
            return View();
        }
        public IActionResult CheckTeacherInfoUI()
        {
            return View();
        }
        public IActionResult FixedGroupInfoUI()
        {
            return View();
        }
        public IActionResult RandomGroupInfoUI()
        {
            return View();
        }
        public IActionResult RollCallListUI()
        {
            return View();
        }
        public IActionResult FixedRollCallUI()
        {
            return View();
        }
        public IActionResult RandomRollCallUI()
        {
            return View();
        }
        public IActionResult TeacherBindingUI()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    public class StudentController : Controller
    {
        // GET: Class
        public IActionResult StudentRollCallUI()
        {
            return View();
        }
        public IActionResult CheckStudentInfoUI()
        {
            return View();
        }
        public IActionResult RandomGroupChooseTopicUI()
        {
            return View();
        }
        public IActionResult CourseUI()
        {
            return View();
        }
        public IActionResult CourseInfoUI()
        {
            return View();
        }
        public IActionResult Seminar()
        {
            return View();
        }
        public IActionResult Score()
        {
            return View();
        }
        public IActionResult RandomGroupList()
        {
            return View();
        }
        public IActionResult FixedGroupList()
        {
            return View();
        }
        public IActionResult StudentMainUI()
        {
            return View();
        }
        public IActionResult StudentBindingUI()
        {
            return View();
        }
    }
}
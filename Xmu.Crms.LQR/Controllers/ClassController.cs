using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/class")]
    public class ClassController : Controller
    {
        //GET api/class/{classId}

        [HttpGet("{classid}")]
        public IActionResult getClassById(int classid)
        {
            var Class1 = new { id = 1, name = "周三1-2节", numstudent = 54, time = "周三 一二节", calling = true, roster = "", proportions = new { a = 20, b = 60, c = 20, report = 50, presentation = 50 } };
            var Class2 = new { id = 2, name = "周三3-4节", numstudent = 65, time = "周三 三四节", calling = true, roster = "", proportions = new { a = 20, b = 60, c = 20, report = 50, presentation = 50 } };
            var Class3 = new { id = 3, name = "周二7-8节", numstudent = 34, time = "周二 七八节", calling = true, roster = "", proportions = new { a = 20, b = 60, c = 20, report = 50, presentation = 50 } };
            var Class4 = new { id = 4, name = "周四7-8节", numstudent = 70, time = "周四 七八节", calling = true, roster = "", proportions = new { a = 20, b = 60, c = 20, report = 50, presentation = 50 } };
            if (classid==1)
                return Json(Class1);
            else if(classid == 2)
                return Json(Class2);
            else if (classid == 3)
                return Json(Class3);
            else
                return Json(Class4);
        }
        //GET api/class/{classId}
        [HttpGet("{classid}/attendance")]
        public JsonResult getAttendanceById(int classid)
        {
            var showLate = Request.Form["showLate"];
            var students = new { numPresent = 4, present = new object[]{ new { id = 2537, name = "张三" }, new { id = 8232, name = "李四" }, new { id = 3245, name = "王五" }, new { id = 1234, name = "赵六" } } };
            var students2 = new { numPresent = 4, present = new object[] { new { id = 2537, name = "张三" }, new { id = 8232, name = "李四" }, new { id = 3245, name = "王五" }, new { id = 1234, name = "赵六" } }, late = new object[] { new { id = 4543, name = "张月明" }, new { id = 2563, name = "李强" }, new { id = 2363, name = "李华" }, new { id = 1531, name = "任为逸" }, new { id = 4523, name = "陈成晨" } } };
            if (showLate == "false")
                return Json(students);
            else
                return Json(students2);
        }
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
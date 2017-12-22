using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/course")]
    public class CourseController : Controller
    {
        // GET: api/Course
        [HttpGet]
        public JsonResult GetCourseList()
        {
            var type = Request.Headers["type"];
            if (type == "teacher")
            {
                var courses = new object[] { new { id = 1, name = "OOAD", description = "面向对象设计与分析" }, new { id = 2, name = "J2EE", description = "J2EE" } };
                return Json(courses);
            }
            else
            {
                var courses = new object[] { new { id = 1, name = "OOAD", teacher = "邱明",description = "面向对象设计与分析" },
                new { id = 2, name = "J2EE", teacher = "邱明", description = "J2EE" },
                new { id = 3, name = "操作系统", teacher = "吴清强", description = "操作系统" },
                new { id = 4, name = "数据仓库", teacher = "王鸿吉", description = "数据仓库" } };
                return Json(courses);

            }
        }
        // GET: api/Course/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 1)
            {
                var course = new { id = 1, name = "OOAD", teacher = "邱明", teacherEmail = "mingqiu@xmu.edu.cn", description = "面向对象设计与分析" };
                return Json(course);
            }
            else
            {
                var course = new { id = 2, name = "J2EE", teacher = "邱明", teacherEmail = "mingqiu@xmu.edu.cn", description = "J2EE" };
                return Json(course);
            }
        }
        // GET: api/Course/{id}/Seminar
        [HttpGet("{id}/seminar")]
        public JsonResult getSeminar(int id)
        {
            if (id == 1)
            {
                var seminars = new object[] { new { id = 1,name = "界面原型设计", description = "界面原型设计",
        groupingMethod = "fixed", startTime = "9月25日", endTime = "10月9日" },
                    new { id = 2,name = "概要设计", description = "模型层与数据库设计",
        groupingMethod = "random", startTime = "10月10日", endTime = "10月24日" }
                };
                return Json(seminars);
            }
            else
            {
                var seminars = new object[] { new { id = 1,name = "包划分", description = "包划分",
        groupingMethod = "random", startTime = "9月25日", endTime = "10月9日" },
                    new { id = 2,name = "概要设计", description = "模型层与数据库设计",
        groupingMethod = "random", startTime = "10月10日", endTime = "10月24日" }
                };
                return Json(seminars);
            }
        }
        //GET: api/course/{courseId}/class
        [HttpGet("{courseId}/class")]
        public IActionResult getClassByCourseId(int courseId)
        {
            var Class = new object[] { new { id = 1, name = "周三1-2节" }, new { id = 2, name = "周三3-4节" } };
            var Class2 = new object[] { new { id = 3, name = "周二7-8节" }, new { id = 4, name = "周四7-8节" } };
            if (courseId == 1)
                return Json(Class);
            else 
                return Json(Class2);
        }
        // POST: api/Course
        [HttpPost]
        public IActionResult Post([FromBody]dynamic Json)
        {
            var course = new { id = Json.id, name = Json.name, status = "success" };
            return Json(course);
        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
        }
    }
}

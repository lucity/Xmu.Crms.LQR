using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/seminar")]
    public class SeminarController : Controller
    {

        // GET: api/Seminar/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 1)
            {
                var seminar = new { id = 1,name = "界面原型设计"};
                return Json(seminar);
            }
            else
            {
                var seminar = new { id = 1, name = "概要设计" };
                return Json(seminar);
            }
        }
        // GET: api/Seminar/5/Group
        [HttpGet("{id}/group")]
        public JsonResult GetGroup(int id)
        {
            string gradeable = Request.Form["gradeable"];
            string classid = Request.Form["classid"];
            string include = Request.Form["include"];
            if(gradeable != null)
            {
                int cid = 1;
                if (cid == 1)
                {
                    var groups = new object[] {
                        new { id = 11, name = "1-A-1" },
                        new { id = 12, name = "1-A-2" },
                        new { id = 13, name = "1-A-3" },
                        new { id = 14, name = "1-C-1" },
                        new { id = 15, name = "1-C-2" },
                        new { id = 16, name = "1-C-3" }
                    };
                    return Json(groups);
                }
                else
                {
                    var groups = new object[] {
                        new { id = 21, name = "2-B-1" },
                        new { id = 22, name = "2-B-2" },
                        new { id = 23, name = "2-B-3" },
                        new { id = 24, name = "2-C-1" },
                        new { id = 25, name = "2-C-2" },
                        new { id = 26, name = "2-C-3" }
                    };
                    return Json(groups);
                }
            }
            if(classid != null)
            {
                var groups = new object[]{ new { id = 1 }, new { id = 2 }, new { id = 3 } };
                return Json(groups);
            }
            if (include != null)
            {
                var group = new
                {
                    id = 1,
                    leader = new { id = 8888, name = "张三", number = "24320xxxxxx" },
                    members = new object[] {
                        new { id = 5324, name = "李四", number = "24320xxxxxx" },
                        new { id = 5678, name = "王五", number = "24320xxxxxx" },
                        new { id = 5324, name = "李四", number = "24320xxxxxx" }
                    },
                    topics = new { id = 257, name = "领域模型与模块" }
                };
                return Json(group);
            }
            else
                return Json(new{ status="false" });
        }
        [HttpGet("{id}/topic")]
        public IActionResult GetTopic(int id)
        {
            var topics = new object[]
            {
                new { id = 257, name = "领域模型与模块", description = "Domain model与模块划分", groupLimit = 5, groupLeft = 2 },
                new { id = 258, name = "模块划分", description = "模块划分，PackageDiagram", groupLimit = 5, groupLeft = 1 },
                new { id = 259, name = "界面设计", description = "界面设计，界面原型设计", groupLimit = 5, groupLeft = 0 },
            };
            return Json(topics);
        }
        // POST: api/Seminar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Seminar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Seminar/5
        public void Delete(int id)
        {
        }
    }
}

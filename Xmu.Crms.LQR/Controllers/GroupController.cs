using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/group")]
    public class GroupController : Controller
    {
        //GET: api/group/{groupid}
        [HttpGet("{id}")]
        public IActionResult getGroupById(int id)
        {
            var group1 = new { id = 1, leader = new { id = 8888, name = "张三" }, members = new object[] { new { id = 5324, name = "李四" }, new { id = 5678, name = "王五" } },topics = new { id = 257, name = "领域模型" },report="" };
            var group2= new { id = 2, leader = new { id = 3423, name = "李明" }, members = new object[] { new { id = 3423, name = "张勇" }, new { id = 2353, name = "赵东" } }, topics = new { id = 257, name = "领域模型" }, report = "" };
            var group3 = new
            {
                id = 3,
                leader = new { id = 1823, name = "于和", number = "24320xxxxxx" },
                members = new object[] {
                            new { id = 2224, name = "周让", number = "24320xxxxxx" },
                            new { id = 1578, name = "吴取", number = "24320xxxxxx" },
                            new { id = 4124, name = "孟茶", number = "24320xxxxxx" }
                        },
                topics = new { id = 275, name = "界面设计" }
            };
            if (id == 1)
                return Json(group1);
            else if(id == 2)
                return Json(group2);
            else
                return Json(group3);
        }
        // GET: api/Group
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Group/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Group
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Group/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Group/5
        public void Delete(int id)
        {
        }
    }
}

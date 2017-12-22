using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/province")]
    public class ProvinceController : Controller
    {
        // GET: api/Province
        [HttpGet]
        public IActionResult GetProvinceList()
        {
            var courses = new object[] { new { id = 1, name = "福建" }, new { id = 2, name = "广东" }, new { id = 3, name = "广西" }, new { id = 4, name = "天津" }, new { id = 5, name = "江苏" }, new { id = 6, name = "安徽" } };
            return Json(courses);
        }

        // GET: api/Province/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Province
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Province/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Province/5
        public void Delete(int id)
        {
        }
    }
}

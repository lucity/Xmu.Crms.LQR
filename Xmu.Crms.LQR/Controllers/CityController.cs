using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api/city")]
    public class CityController : Controller
    {
        // GET: api/City
        [HttpGet]
        public IActionResult GetCityList()
        {
            var courses = new object[] { new { id = 1, name = "泉州"}, new { id = 2, name = "福州"}, new { id = 3, name = "厦门" } };
            return Json(courses);
        }

        // GET: api/City/5
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            if (id == 1)
            {
                var courses = new object[] { new { id = 11, name = "厦门" }, new { id = 12, name = "福州" }, new { id = 13, name = "泉州" } };
                return Json(courses);
            }
            else if(id == 2)
            {
                var courses = new object[] { new { id = 21, name = "广州" }, new { id = 22, name = "汕头" }, new { id = 23, name = "深圳" } };
                return Json(courses);
            }
            else
            {
                var courses = new object[] { new { id = 31, name = "南宁" }, new { id = 32, name = "柳州" }, new { id = 33, name = "桂林" } };
                return Json(courses);
            }

        }

        // POST: api/City
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/City/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/City/5
        public void Delete(int id)
        {
        }
    }
}

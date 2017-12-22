using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Xmu.Crms.Shared.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;

namespace Xmu.Crms.Controllers
{
    [Produces("application/json")]
    [Route("/api")]
    public class MeController : Controller
    {
        private JwtSettings _jwtSettings;
        public MeController(IOptions<JwtSettings> _jwtSettingsAccesser)
        {
            _jwtSettings = _jwtSettingsAccesser.Value;
        }
        // GET: api/Me
        [Authorize]
        [HttpGet("me")]
        public IActionResult GetMe()
        {
            var token = Request.Headers["token"];
            JwtSecurityToken jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var type = jwt.Claims.ElementAt(1).Value;
            if (type == "student")
            {
                var me = new { id = 1, type = "student", name = "张三", number = "24320152202333", phone = "18911114514", email = "24320152202333@stu.xmu.edu.cn", gender = "male", school = new { id = 32, name = "厦门大学" }, title = "", avatar = "../../images/user.png" };
                return Json(me);
            }
            else
            {
                var me = new { id = 2, type = "teacher", name = "邱明", number = "1121432543", phone = "18987965721", email = "1121432543@xmu.edu.cn", gender = "male", school = new { id = 32, name = "厦门大学" }, title = "", avatar = "../../images/user.png" };
                return Json(me);
            }
        }
        // POST: api/Me
        [HttpPost("me")]
        public IActionResult POSTMe([FromBody]dynamic json)
        {
            return Json(new { status="success" });
        }
        // PUT: api/Me/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Me/5
        public void Delete(int id)
        {
        }
        // POST: api/signin
        [HttpPost("signin")]
        public JsonResult Login([FromBody]dynamic json) 
        {
            var student = new { id = 3486, type = "student", name = "张三" };
            var teacher = new { id = 4532, type = "teacher", name = "邱明" };
            string a = json.username;
            string b = json.password;
            if (a == "18911114514" && b == "qwer2345!")
            {
                var claims = new Claim[]
                {
                    new Claim("name", "karl"),
                    new Claim(ClaimTypes.Role, "student")
                };
                var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtSettings.ServerSecretKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    null,
                    null,
                    claims, 
                    DateTime.Now, DateTime.Now.AddMinutes(30),
                    creds);
                var t = token.Claims.ElementAt(1);
                return Json(new { status="200", type = t, token = new JwtSecurityTokenHandler().WriteToken(token)});
            }
            else if (a == "18911118978" && b == "asdf1234!")
                return Json(teacher);
            else return Json(new { status = "err" });
            

        }

    }
}

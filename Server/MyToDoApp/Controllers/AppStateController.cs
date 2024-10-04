using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppStateController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetState()
        {
            var keys = HttpContext.Session.Keys;
            return Ok("Session state" + HttpContext.Session.IsAvailable);
        }

        [HttpGet]
        [Route("save-to-session")]
        public IActionResult SaveToSession(string name)
        {
            HttpContext.Session.SetString("your_name", name);
            return Content($"{name} save to session");
        }

        [HttpGet]
        [Route("fetch-from-session")]
        public IActionResult FetchFromSession()
        {
            var result = HttpContext.Session.GetString("your_name");

            return Ok("Name: " + result);
        }
    }
}

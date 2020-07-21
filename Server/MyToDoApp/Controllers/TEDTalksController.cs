using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;

namespace MyToDoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TEDTalksController : ControllerBase
    {
        [HttpGet]
        public List<TEDTalk> Get()
        {
            TEDTalk t = new TEDTalk();
            return new List<TEDTalk>() { t };
        }
    }
}
